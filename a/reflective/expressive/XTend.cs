//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Components;

    using XPR = System.Linq.Expressions.Expression;

    partial class XTend
    {
        [MethodImpl(Inline)]
        static T cast<T>(object src)
            => (T)src;

        /// <summary>
        /// Tests whether an expression is a conversion
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsConversion(this Expression x)
            => x.NodeType == ExpressionType.Convert;

        /// <summary>
        /// Extracts the operaand from the expression
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Expression GetSubject(this UnaryExpression x)
            => x.Operand;

        public static NamedValue<T> Evaluate<T>(this Expression<Func<T>> fx)
        {
            var name = fx.TryGetAccessedMember().MapValueOrElse(x => x.Name, () => "?");
            var value = fx.Compile().Invoke();
            return (name, value);
        }

        /// <summary>
        /// Gets the expression that directly identifies the selected subject
        /// </summary>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static Expression SelectionSubject<M>(this Expression<Func<M>> selector)
            => selector.IsConversion()
                ? (selector.Body as UnaryExpression).GetSubject()
                : selector.Body;

        /// <summary>
        /// Gets the expression that directly identifies the selected subject
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        static Expression SelectionSubject<T, M>(this Expression<Func<T, M>> selector)
            => selector.IsConversion()
                ? (selector.Body as UnaryExpression).GetSubject()
                : selector.Body;

        /// <summary>
        /// Extracts the property info for the property referenced by an expression delegate
        /// </summary>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static PropertyInfo GetProperty<P>(this Expression<Func<P>> selector)
            => cast<PropertyInfo>(cast<MemberExpression>(selector.SelectionSubject()).Member);

        /// <summary>
        /// Extracts the property info for the property referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static PropertyInfo GetProperty<T, P>(this Expression<Func<T, P>> selector)
            => cast<PropertyInfo>(cast<MemberExpression>(selector.SelectionSubject()).Member);

        /// <summary>
        /// Determines the name of the property as identified by an expression delegate
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static string SelectedPropertyName<T, P>(this Expression<Func<T, P>> selector)
            => selector.GetProperty().Name;

        /// <summary>
        /// Extracts the field info for the field referenced by an expression delegate
        /// </summary>
        /// <typeparam name="F">The field type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static FieldInfo GetField<F>(this Expression<Func<F>> selector)
            => cast<FieldInfo>(cast<MemberExpression>(selector.SelectionSubject()).Member);

        /// <summary>
        /// Extracts the field info for the field referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static FieldInfo GetField<T, P>(this Expression<Func<T, P>> selector)
            => cast<FieldInfo>(cast<MemberExpression>(selector.SelectionSubject()).Member);

        /// <summary>
        /// Extracts the member info for the member referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The first selector parameter</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static MemberInfo GetMember<T, M>(this Expression<Func<T, M>> selector)
            => cast<MemberInfo>(cast<MemberExpression>(selector.Body).Member);

        /// <summary>
        /// Extracts the <see cref="ValueMember"/> for the member referenced by a an expression delegate
        /// </summary>
        /// <typeparam name="T">The member selector</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static ValueMember GetValueMember<T, M>(this Expression<Func<T, M>> selector)
        {
            var property = selector.GetProperty();
            if (property != null)
                return property;

            var field = selector.GetField();
            if (field != null)
                return field;

            var member = selector.TryGetAccessedMember();
            if (member)
                throw new ArgumentException($"Members of type {(member.ValueOrDefault()).MemberType} are not considered value memembers");
            else
                throw new ArgumentException($"Could not determine any member from {selector}");
        }

        /// <summary>
        /// Extracts the name of the value member referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The member selector</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static string GetValueMemberName<T, M>(this Expression<Func<T, M>> selector)
            => selector.GetValueMember().Name;

        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The function return type</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T>(this Expression<Func<T>> selector)
        {
            if (selector.Body is MethodCallExpression)
                return cast<MethodCallExpression>(selector.Body).Method;
            else if (selector.Body.IsConversion())
                return (cast<UnaryExpression>(selector.Body).Operand as MethodCallExpression).Method;
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first function argument</typeparam>
        /// <typeparam name="T2">The function return type</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T1, T2>(this Expression<Func<T1, T2>> selector)
            => cast<MethodCallExpression>(selector.Body).Method;

        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first function argument</typeparam>
        /// <typeparam name="T2">The second function argument</typeparam>
        /// <typeparam name="R">The function return type</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T1, T2, R>(this Expression<Func<T1, T2, R>> selector)
            => cast<MethodCallExpression>(selector.Body).Method;

        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first function argument</typeparam>
        /// <typeparam name="T2">The second function argument</typeparam>
        /// <typeparam name="T3">The third function argument</typeparam>
        /// <typeparam name="R">The function return type</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T1, T2, T3, R>(this Expression<Func<T1, T2, T3, R>> selector)
            => cast<MethodCallExpression>(selector.Body).Method;

        /// <summary>
        /// Extracts the method for the action referenced by an an expression delegate
        /// </summary>
        /// <typeparam name="T">The action argument</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T>(this Expression<Action<T>> selector)
            => cast<MethodCallExpression>(selector.Body).Method;

        /// <summary>
        /// Extracts the method info for the action referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first action argument</typeparam>
        /// <typeparam name="T2">The second action argument</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T1, T2>(this Expression<Action<T1, T2>> selector)
            => cast<MethodCallExpression>(selector.Body).Method;

        /// <summary>
        /// Extracts the method info for the action referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first action argument</typeparam>
        /// <typeparam name="T2">The second action argument</typeparam>
        /// <typeparam name="T3">The third action argument</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T1, T2, T3>(this Expression<Action<T1, T2, T3>> selector)
            => cast<MethodCallExpression>(selector.Body).Method;

        /// <summary>
        /// Extracts the method info for the action referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first action argument</typeparam>
        /// <typeparam name="T2">The second action argument</typeparam>
        /// <typeparam name="T3">The third action argument</typeparam>
        /// <typeparam name="T4">The fourth action argument</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> selector)
            => cast<MethodCallExpression>(selector.Body).Method;

        /// <summary>
        /// Extracts property info from a member expression, if possbile, and otherwise returns null
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static PropertyInfo GetAccessedProperty(this Expression x)
            => cast<PropertyInfo>(cast<MemberExpression>(x)?.Member);

        /// <summary>
        /// Extracts member info from an expression, if possbile; otherwise returns none
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Option<MemberInfo> TryGetAccessedMember(this Expression X)
        {
            var M = Option.TryCast<MemberExpression>(X).ValueOrDefault();
            if (M != null)
                return M.Member;
            else
                return Option.TryCast<LambdaExpression>(X).Select(y => y.Body.TryGetAccessedMember().ValueOrDefault());
        }

        /// <summary>
        /// Extracts property info from an expression, if possbile; otherwise returns none
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Option<PropertyInfo> TryGetAccesedProperty(this Expression x)
        {
            var candiate = Option.TryCast<MemberExpression>(x).Select(GetAccessedProperty);
            if (candiate)
                return candiate;
            else
                return Option.TryCast<LambdaExpression>(x).Select(y => y.Body.TryGetAccesedProperty().ValueOrDefault());
        }

        public static Option<MemberInfo> TryGetAccessedMember(this BinaryExpression X)
            => X.Left.TryGetAccessedMember().ValueOrElse(() => X.Right.TryGetAccessedMember().ValueOrDefault());

        public static Option<object> GetValue(this BinaryExpression X)
            => X.Left.GetValue().ValueOrElse(() => X.Right.GetValue());

        public static Option<object> TryGetConstant(this Expression x)
            => Option.TryCast<ConstantExpression>(x).Select(GetConstant);

        public static Option<object> GetValue(this Expression X)
        {
            var value = X.TryGetConstant();
            if (!value)
            {
                var N = (X as NewExpression);
                if (N != null)
                {
                    var args = N.Arguments.Select(A => A.TryGetConstant().ValueOrDefault()).ToArray();
                    value = Activator.CreateInstance(N.Type, args);
                }
            }
            return value;
        }

        /// <summary>
        /// Tests whether a member is wrapped in a conversion
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="TResult">The member type</typeparam>
        /// <param name="selector">Expression that identifies the member</param>
        public static bool IsConversion<T, TResult>(this Expression<Func<T, TResult>> selector)
            => selector.Body.IsConversion();

        /// <summary>
        /// Tests whether the test expression is a member access expression
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsMemberAccess(this Expression x)
            => x.NodeType == ExpressionType.MemberAccess;

        /// <summary>
        /// Tests whether the test expression is a function call
        /// </summary>
        /// <param name="x">The expression to examine</param>
        /// <returns></returns>
        public static bool IsCall(this Expression x)
            => x.NodeType == ExpressionType.Call;

        /// <summary>
        /// Returns the method invoked by an expression, if any
        /// </summary>
        /// <param name="x">The expression to test</param>
        public static Option<MethodInfo> GetCalledMethod(this Expression x)
            => cast<MethodCallExpression>(x)?.Method;

        /// <summary>
        /// Tests whether an expression is an application of the LINQ select operator
        /// </summary>
        /// <param name="x">The expression to test</param>
        public static bool IsSelect(this Expression x)
            => x.GetCalledMethod().Select(m => m.Name == nameof(Enumerable.Select)).ValueOrDefault(false);

        /// <summary>
        /// Tests whether an expression is a logical operator
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsLogical(this Expression x)
            => x.NodeType == ExpressionType.AndAlso ||
                x.NodeType == ExpressionType.OrElse ||
                x.NodeType == ExpressionType.Not;

        /// <summary>
        /// Tests whether an expression is a lambda expression
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsLambda(this Expression x)
            => x.NodeType == ExpressionType.Lambda;

        /// <summary>
        /// Tests whether an expression is a logical disjunction
        /// </summary>
        /// <param name="x">The expression to examine</param>
        static bool IsDisjunction<X>(this X x)
            where X : Expression
            => x.TryGetDisjunction().Exists;

        /// <summary>
        /// Tests whether an expression is a logical conjunction
        /// </summary>
        /// <param name="x">The expression to examine</param>
        static bool IsConjunction<X>(this X x)
            where X : Expression
            => x.TryGetConjunction().Exists;

        /// <summary>
        /// Deterines whether the test expression is either a logical conjuntion or disjunction
        /// </summary>
        /// <param name="X">The expression to examine</param>
        public static bool IsJunction(this Expression X)
            => X.IsConjunction() || X.IsDisjunction();

        /// <summary>
        /// Performs a type-test on an expression
        /// </summary>
        /// <typeparam name="X1">The first candidate type</typeparam>
        /// <typeparam name="X2">The second candidate type</typeparam>
        /// <param name="x">The expression to test</param>
        public static bool IsOneOf<X1, X2>(this Expression X)
            where X1 : Expression
            where X2 : Expression
                => (X is X1) || (X is X2);

        /// <summary>
        /// Performs a type-test on an expression
        /// </summary>
        /// <typeparam name="X1">The first candidate type</typeparam>
        /// <typeparam name="X2">The second candidate type</typeparam>
        /// <typeparam name="X3">The third candidate type</typeparam>
        /// <param name="x">The expression to test</param>
        public static bool IsOneOf<X1, X2, X3>(this Expression X)
            where X1 : Expression
            where X2 : Expression
            where X3 : Expression
                => X.IsOneOf<X1, X2>() || (X is X3);

        /// <summary>
        /// Performs a type-test on an expression
        /// </summary>
        /// <typeparam name="X1">The first candidate type</typeparam>
        /// <typeparam name="X2">The second candidate type</typeparam>
        /// <typeparam name="X3">The third candidate type</typeparam>
        /// <typeparam name="X4">The fourth candidate type</typeparam>
        /// <param name="x">The expression to test</param>
        public static bool IsOneOf<X1, X2, X3, X4>(this Expression x)
            where X1 : Expression
            where X2 : Expression
            where X3 : Expression
            where X4 : Expression
                => x.IsOneOf<X1, X2, X3>() || (x is X4);

        /// <summary>
        /// Creates a delegate for an emitter
        /// </summary>
        /// <param name="Host">The declaring type instance, if applicable</param>
        /// <typeparam name="X">The result type</typeparam>
        public static Func<X> Func<X>(this MethodInfo method, object Host = null)
        {
            var instance = Host != null ? XPR.Constant(Host) : default(XPR);
            var callResult = XPR.Call(instance, method);
            return XPR.Lambda<Func<X>>(callResult).Compile();
        }

        /// <summary>
        /// Creates a delegate for a function f:X->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X, Y> Func<X, Y>(this MethodInfo method, object Host = null)
        {
            var instance = Host != null ? XPR.Constant(Host) : default(XPR);
            var src = XPR.Parameter(typeof(X), "src");
            var callResult = XPR.Call(instance, method, src);
            return XPR.Lambda<Func<X, Y>>(callResult, src).Compile();
        }

        /// <summary>
        /// Creates a delegate for a function f:X1->X2->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X1, X2, Y> Func<X1, X2, Y>(this MethodInfo method, object Host = null)
        {
            var instance = Host != null ? XPR.Constant(Host) : default(XPR);
            var x1 = XPR.Parameter(typeof(X1), "x1");
            var x2 = XPR.Parameter(typeof(X2), "x2");
            var callResult = XPR.Call(instance, method, x1, x2);
            return XPR.Lambda<Func<X1, X2, Y>>(callResult, x1, x2).Compile();
        }

        /// <summary>
        /// Creates a delegate for a binary operator f:X->X->X realized by a specified method
        /// </summary>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        /// <typeparam name="X">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<X> BinaryOp<X>(this MethodInfo method, object host = null)
            => method.Func<X,X,X>(host).ToBinaryOp();

        /// <summary>
        /// Creates a delegate for a function f:X1->X2->X3->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="X3">Tye type of the third parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X1, X2, X3, Y> Func<X1, X2, X3, Y>(this MethodInfo method, object host = null)
        {
            var instance = host != null ? XPR.Constant(host) : default(XPR);
            var x1 = XPR.Parameter(typeof(X1), "x1");
            var x2 = XPR.Parameter(typeof(X2), "x2");
            var x3 = XPR.Parameter(typeof(X3), "x3");
            var callResult = XPR.Call(instance, method, x1, x2, x3);
            return XPR.Lambda<Func<X1, X2, X3, Y>>(callResult, x1, x2, x3).Compile();
        }

        /// <summary>
        /// Creates a delegate for a function f:X1->X2->X3->X4->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="X3">Tye type of the third parameter</typeparam>
        /// <typeparam name="X4">Tye type of the fourth parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X1, X2, X3, X4, Y> Func<X1, X2, X3, X4, Y>(this MethodInfo method, object host = null)
        {
            var instance = host != null ? XPR.Constant(host) : default(XPR);
            var x1 = XPR.Parameter(typeof(X1), "x1");
            var x2 = XPR.Parameter(typeof(X2), "x2");
            var x3 = XPR.Parameter(typeof(X3), "x3");
            var x4 = XPR.Parameter(typeof(X4), "x4");
            var callResult = XPR.Call(instance, method, x1, x2, x3);
            return XPR.Lambda<Func<X1, X2, X3, X4, Y>>(callResult, x1, x2, x3, x4).Compile();
        }

        /// <summary>
        /// Returns the expression if it is a logical conjunction and None otherwise
        /// </summary>
        /// <param name="x">The expression to examine</param>
        static Option<X> TryGetConjunction<X>(this X x)
            where X : Expression
            => x.NodeType == ExpressionType.AndAlso ? x : Option.none<X>();

        /// <summary>
        /// Returns the expression if it is a logical disjunction and None otherwise
        /// </summary>
        /// <param name="x">The expression to examine</param>
        static Option<X> TryGetDisjunction<X>(this X x)
            where X : Expression
                => x.NodeType == ExpressionType.OrElse ? x : Option.none<X>();

        /// <summary>
        /// Extracts the value from a constant expression or returns 
        /// </summary>
        /// <param name="x">The expression to examine</param>
        static object GetConstant(this Expression x)
            => cast<ConstantExpression>(x)?.Value;
    }
}