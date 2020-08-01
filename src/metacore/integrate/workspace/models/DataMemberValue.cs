//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    using static Konst;

    /// <summary>
    /// Encapsulates an instance value of a <see cref="DataMember"/> 
    /// </summary>
    public class DataMemberValue : IEquatable<DataMemberValue>
    {
        public static bool operator ==(DataMemberValue x, DataMemberValue y)
            => Object.Equals(x, y);

        public static bool operator !=(DataMemberValue x, DataMemberValue y)
            => !(x == y);

        public DataMemberValue(Type ValueType, string MemberName, object Value)
        {
            this.ValueType = ValueType;
            this.MemberName = MemberName;
            this.Value = Value;
        }

        /// <summary>
        /// The encapsulated value type
        /// </summary>
        public Type ValueType { get; }

        /// <summary>
        /// The name of the member for which a value has been captured
        /// </summary>
        public string MemberName { get; }

        /// <summary>
        /// The encapsulated value
        /// </summary>
        public object Value { get; }

        public override bool Equals(object other)
            => other is DataMemberValue 
                ? this.Equals((DataMemberValue)other) : false;

        public bool Equals(DataMemberValue other)
            =>    (MemberName.Equals(other.MemberName)  
            && (ValueType?.Equals(other.ValueType) ?? false))  
                ? Object.Equals(this.Value, other.Value) 
                : false;

        public override int GetHashCode()
        => Value.GetHashCode();

        public override string ToString()
            => $"{MemberName}: {Value?.ToString() ?? "null"}";
    
    }
}