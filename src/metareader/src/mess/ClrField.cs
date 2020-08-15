//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{    
    /// <summary>
    /// A representation of a field in the target process.
    /// </summary>
    public abstract class ClrField
    {
        /// <summary>
        /// Gets the <see cref="ClrType"/> containing this field.
        /// </summary>
        public abstract ClrType Parent { get; }

        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the type token of this field.
        /// </summary>
        public abstract int Token { get; }

        /// <summary>
        /// Gets the type of the field.  Note this property may return <see langword="null"/> on error.  There is a bug in several versions
        /// of our debugging layer which causes this.  You should always null-check the return value of this field.
        /// </summary>
        public abstract ClrType Type { get; }

        /// <summary>
        /// Gets the element type of this field.  Note that even when Type is <see langword="null"/>, this should still tell you
        /// the element type of the field.
        /// </summary>
        public abstract ClrElementType ElementType { get; }

        /// <summary>
        /// Gets a value indicating whether this field is a primitive (<see cref="int"/>, <see cref="float"/>, etc).
        /// </summary>
        /// <returns>True if this field is a primitive (<see cref="int"/>, <see cref="float"/>, etc), false otherwise.</returns>
        public virtual bool IsPrimitive => ElementType.IsPrimitive();

        /// <summary>
        /// Gets a value indicating whether this field is a value type.
        /// </summary>
        /// <returns>True if this field is a value type, false otherwise.</returns>
        public virtual bool IsValueType => ElementType.IsValueType();

        /// <summary>
        /// Gets a value indicating whether this field is an object reference.
        /// </summary>
        /// <returns>True if this field is an object reference, false otherwise.</returns>
        public virtual bool IsObjectReference => ElementType.IsObjectReference();

        /// <summary>
        /// Gets the size of this field.
        /// </summary>
        public abstract int Size { get; }

        /// <summary>
        /// Gets a value indicating whether this field is public.
        /// </summary>
        public abstract bool IsPublic { get; }

        /// <summary>
        /// Gets a value indicating whether this field is private.
        /// </summary>
        public abstract bool IsPrivate { get; }

        /// <summary>
        /// Gets a value indicating whether this field is internal.
        /// </summary>
        public abstract bool IsInternal { get; }

        /// <summary>
        /// Gets a value indicating whether this field is protected.
        /// </summary>
        public abstract bool IsProtected { get; }

        /// <summary>
        /// If the field has a well defined offset from the base of the object, return it (otherwise -1).
        /// </summary>
        public virtual int Offset => -1;

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            ClrType type = Type;
            if (type != null)
                return $"{type.Name} {Name}";

            return Name;
        }
    }        
}