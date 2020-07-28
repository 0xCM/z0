//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ClrDataModel
    {
        /// <summary>
        /// Represents an instance field of a type.   Fundamentally it respresents a name and a type
        /// </summary>
        public abstract class ClrInstanceField : ClrField
        {
            public abstract T Read<T>(ulong objRef, bool interior) 
                where T : unmanaged;
     
            public abstract ClrObject ReadObject(ulong objRef, bool interior);
     
            public abstract ClrValueType ReadStruct(ulong objRef, bool interior);
     
            public abstract string ReadString(ulong objRef, bool interior);

            /// <summary>
            /// Returns the address of the value of this field.  Equivalent to GetFieldAddress(objRef, false).
            /// </summary>
            /// <param name="objRef">The object to get the field address for.</param>
            /// <returns>The value of the field.</returns>
            public virtual ulong GetAddress(ulong objRef)
            {
                return GetAddress(objRef, false);
            }

            /// <summary>
            /// Returns the address of the value of this field.  Equivalent to GetFieldAddress(objRef, false).
            /// </summary>
            /// <param name="objRef">The object to get the field address for.</param>
            /// <param name="interior">
            /// Whether the enclosing type of this field is a value class,
            /// and that value class is embedded in another object.
            /// </param>
            /// <returns>The value of the field.</returns>
            public abstract ulong GetAddress(ulong objRef, bool interior);
        }       
    }
}