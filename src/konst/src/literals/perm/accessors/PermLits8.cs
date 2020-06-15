//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Perm8L;

    partial class PermLits
    {               
        public const Perm8L Perm8Identity = (Perm8L)(
            (uint)A       | (uint)B << 3  | (uint)C << 6  | (uint)D << 9 
          | (uint)E << 12 | (uint)F << 15 | (uint)G << 18 | (uint)H << 21
              );

        public const Perm8L Perm8Reversed = (Perm8L)(
            (uint)H       | (uint)G << 3  | (uint)F << 6  | (uint)E << 9 
          | (uint)D << 12 | (uint)C << 15 | (uint)B << 18 | (uint)A << 21
            );
    }
}