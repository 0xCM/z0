//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial class Stacked
    {
        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack4 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack4 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack8 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack8 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack16 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack16 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack32 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack32 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack64 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack64 src)
            => ref first(in src.C0);

        public ref struct CharStack2
        {
            internal char C0;

            char C1;

        }

        public ref struct CharStack4
        {
            internal CharStack2 C0;

            CharStack2 C1;
        }

        public ref struct CharStack8
        {
            internal CharStack4 C0;

            CharStack4 C1;
        }

        public ref struct CharStack16
        {
            internal CharStack8 C0;

            CharStack8 C1;
        
        }

        public ref struct CharStack32
        {
            internal CharStack16 C0;

            CharStack16 C1;
        
        }

        public ref struct CharStack64
        {
            internal CharStack32 C0;

            CharStack32 C1;
        
        }
    }
}