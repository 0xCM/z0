//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Base class for objects that are identified only by the fields they encapsulate
    /// </summary>
    /// <typeparam name="T">The concrete value object type</typeparam>
    /// <remarks>
    /// Provides basic facility for representing values to compensate for the fact 
    /// that, regrettably, C# does not have a record type, comparable to that of F# for instance
    /// Value objects should normally be immutable and composed only of primitives, value types
    /// and collections of other value objects
    /// </remarks>
    public abstract class DataObject<T> : IDataObject<T>, IEquatable<T> 
        where T : DataObject<T>
    {
        static readonly Lazy<DataMember[]> _DataMembers
            = new Lazy<DataMember[]>(() => typeof(T).DataMembers());

        static Func<T> Factory = CreateFactory();

        const int P1 = 17;

        const int P2 = 23;

        static Func<T> CreateFactory()
            => () => (T)FormatterServices.GetUninitializedObject(typeof(T));


        static DataMemberValue[] Destructure(DataObject<T> x)
            => (from m in DataMembers
                let value = m.GetValue(x)
                select new DataMemberValue(typeof(T), m.Name, value)
                        ).ToArray();

        public static DataMember[] DataMembers 
            => _DataMembers.Value;


        /// <summary>
        /// The object equality operator
        /// </summary>
        /// <param name="lhs">The first object</param>
        /// <param name="rhs">The second object</param>
        /// <returns></returns>
        public static bool operator ==(DataObject<T> lhs, DataObject<T> rhs)
        {
            if (object.ReferenceEquals(lhs, rhs))
                return true;

            if (((object)lhs == null) || ((object)rhs == null))
                return false;

            return lhs.Equals(rhs);        
        }

        /// <summary>
        /// The object not equal operator
        /// </summary>
        /// <param name="lhs">The first object</param>
        /// <param name="rhs">The second object</param>
        /// <returns></returns>
        public static bool operator !=(DataObject<T> lhs, DataObject<T> rhs) 
            => !(lhs == rhs);

        Lazy<DataMemberValue[]> _MemberValues { get; }

        protected DataObject()
            => _MemberValues = new Lazy<DataMemberValue[]>(() => Destructure(this));

        DataMember[] IDataObject.DataMembers 
            => DataMembers;

        /// <summary>
        /// Adjudicates value equality
        /// </summary>
        /// <param name="obj">The object to compare this object to</param>
        /// <returns></returns>
        public sealed override bool Equals(object obj)
            => (obj as T) != null ? Equals(obj as T) : false;

        /// <summary>
        /// Calculates hash code based on value
        /// </summary>
        public override int GetHashCode()
            { unchecked { return GetHashCode(P1, P2); } }

        /// <summary>
        /// Calculates hash code for value object
        /// </summary>
        /// <param name="p1">The first factor</param>
        /// <param name="p2">The second factor</param>
        /// <remarks>
        /// If usage context is performance sensitive, then override and implement without reflection!
        /// See http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
        /// </remarks>
        protected virtual int GetHashCode(int p1, int p2)
        {
            var hash = P1 * P2;

            foreach (var m in DataMembers)
            {
                var fval = m.GetValue(this);
                hash = hash * P2 + (fval != null ? fval.GetHashCode() : 0);
            }

            return hash;
        }

        /// <summary>
        /// Determine whether two value objects have identical values and are thus equal
        /// </summary>
        /// <param name="other">The other value object</param>
        /// <returns></returns>
        public virtual bool Equals(T other)
        {
            if (other == null)
                return false;

            if (GetType() != other.GetType())
                return false;

            bool result = true;
            foreach (var m in DataMembers)
            {
                var xVal = m.GetValue(this);
                var yVal = m.GetValue(other);

                if (xVal == null && yVal != null)
                    return false;

                if (xVal != null && yVal == null)
                    return false;

                if (yVal == null && yVal == null)
                    continue;
                else if (xVal != null)
                    result &= xVal.Equals(yVal);
                else
                    result &= yVal.Equals(xVal);

                if (!result)
                    break;

            }
            return result;
        }

        /// <summary>
        /// Formats a supplied object by rendering it as a collection of key-value pairs
        /// Obviously, this will work for any type but, in the case of an object that is fully-characterized
        /// by its public properties, the formatted string will represent the total state of the object
        /// </summary>
        public virtual string FormatValue()
        {
            var sb = text.build();
            var count = DataMembers.Length;
            for (int i = 0; i < count; i++)
            {
                var field = DataMembers[i];
                sb.AppendFormat("{0}={1}", field.Name, field.GetValue(this));
                if (i < count - 1)
                    sb.Append(";");
            }
            return sb.ToString();
        }

        public DataMemberValue[] Destructure()
            => _MemberValues.Value;

        public (DataMemberValue, DataMemberValue)[] Delta(T other)
            => (Destructure().Zip(other.Destructure(),
                (x, y) => new
                {
                    x.MemberName,
                    First = x,
                    Second = y
                }).Where(x => !(object.Equals(x.First.Value, x.Second.Value)))
                .Select(x => (x.First, x.Second))).ToArray();
        
                    
        public virtual Option<TKey> GetKey<TKey>()
            => Option.none<TKey>();

        protected static void SetMemberValue(T DataObject, string MemberName, object MemberValue)
        {
            var member = DataMembers.Single(f => f.Name == MemberName);
            member.SetValue(DataObject, MemberValue);
            member.SetValue(DataObject, Convert.ChangeType(MemberValue, member.DataType));
        }

        public static T FromMemberValues(DataMemberValue[] values)
        {
            var DataObject = Factory();
            z.iter(values, value => SetMemberValue(DataObject, value.MemberName, value.Value));
            return DataObject;
        }

        public override string ToString()
            => FormatValue();
    }
}