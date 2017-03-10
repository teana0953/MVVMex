using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace CH07.CookbookMVVM {
	public abstract class ObservableObject : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propName) {
			Debug.Assert(GetType().GetProperty(propName) != null);      // Check at runtime that the property with that name actually exists
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propName));
		}

        //protected bool SetProperty<T>(ref T field, T value, string propName) {
        //	if(!EqualityComparer<T>.Default.Equals(field, value)) {
        //		field = value;
        //		OnPropertyChanged(propName);
        //		return true;
        //	}
        //	return false;
        //}
        /****** Implement sample*******
            int _age;
            public int Age{
                get{return _age;}
                set{SetProperty(ref _age,value, ()=>Age);}
            }
        *******************************/


        // implementing with C# 5.0: CallerMemberName providing the calling member name
        /// <summary>
        /// Set property. Return value indicate whether the sent value was actually different than the previous one.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="propName"></param>
        /// <returns></returns>
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propName=null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propName);
                return true;
            }
            return false;
        }
        /****** Implement sample*******
            int _age;
            public int Age{
                get{return _age;}
                set{SetProperty(ref _age,value);}
            }
        *******************************/

        protected bool SetProperty<T>(ref T field, T value, Expression<Func<T>> expr) {     // lambda expression 以 Expression object 代表
			if(!EqualityComparer<T>.Default.Equals(field, value)) {
				field = value;
				var lambda = (LambdaExpression)expr;    //  擷取類似於 .NET 方法主體的程式碼區塊
				MemberExpression memberExpr;        // 取得要存取的欄位或屬性
				if(lambda.Body is UnaryExpression) {
					var unaryExpr = (UnaryExpression)lambda.Body;   // 取得 Lambda 運算式的主題
					memberExpr = (MemberExpression)unaryExpr.Operand;   // 取得一元作業的運算元
				}
				else {
					memberExpr = (MemberExpression)lambda.Body;
				}

				OnPropertyChanged(memberExpr.Member.Name);
				return true;
			}
			return false;
		}
	}
}
