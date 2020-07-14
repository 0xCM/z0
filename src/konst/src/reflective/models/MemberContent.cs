//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    /// <summary>
    /// Unifies fields and properites from a structural metadata represetnation perspective
    /// </summary>
    public readonly struct DataMember
    {    
        /// <summary>
        /// The represented member
        /// </summary>
        public readonly MemberInfo Member;

        public readonly bool IsField;

        public readonly Option<FieldInfo> BackingField;

        [MethodImpl(Inline)]
        public static implicit operator DataMember(PropertyInfo src) 
            => new DataMember(src);

        [MethodImpl(Inline)]
        public static implicit operator DataMember(FieldInfo src) 
            => new DataMember(src);

        [MethodImpl(Inline)]
        public static implicit operator MemberInfo(DataMember src) 
            => src.Member;

        [MethodImpl(Inline)]
        public DataMember(PropertyInfo src)
        {
            Member = src;
            IsField = false;
            BackingField = none<FieldInfo>();
        }

        [MethodImpl(Inline)]
        public DataMember(FieldInfo src)
        {
            Member = src;
            IsField = true;
            BackingField = none<FieldInfo>();
        }

        [MethodImpl(Inline)]
        public DataMember(PropertyInfo prop, FieldInfo field)
        {
            Member = prop;
            IsField = false;
            BackingField = field;
        }
 
        public object GetValue(object o)
        {
            var objType = o.GetType();
            var declarer = Member.DeclaringType;
            return IsField ? (Member as FieldInfo).GetValue(o)
                : (Member as PropertyInfo).GetValue(o);
        }

        public T GetValue<T>(object o)
            => (T)(IsField ? (Member as FieldInfo).GetValue(o) 
                : (Member as PropertyInfo).GetValue(o));

        public void SetValue(object o, object value)
        {
            if (IsField)
                (Member as FieldInfo).SetValue(o, value);
            else
            {
                //A property with no setter but with a backing field
                if (BackingField)
                    BackingField.Value.SetValue(o, value);
                else
                    (Member as PropertyInfo).SetValue(o, value);
            }
        }

        /// <summary>
        /// The member name
        /// </summary>
        public string Name
            => Member.Name;

        /// <summary>
        /// The type of data represented by the member
        /// </summary>
        public Type DataType
        {
            [MethodImpl(Inline)]
             get => IsField ? (Member as FieldInfo).FieldType : (Member as PropertyInfo).PropertyType;
        }

        public override string ToString()
            => Member.ToString();
    }
}