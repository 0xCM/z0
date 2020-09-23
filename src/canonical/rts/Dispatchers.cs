//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Hex4Seq;
    using static z;

    [ApiHost]
    public ref struct Dispatchers
    {
        [Op]
        public Hex4Seq dispatch(Hex4Seq src, Hex4Seq dst)
        {
            switch(src)
            {
                case x00:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & x01;
                        case x02:
                            return x02 | x01;
                        case x03:
                            return x03 ^ x01;
                        case x04:
                            return ~(x04 & x01);
                        case x05:
                            return ~(x05 | x01);
                        case x06:
                            return ~(x06 ^ x01);
                        case x07:
                            return x07 & ~x01;
                        case x08:
                            return x08 | ~x01;
                        case x09:
                            return x09 ^ ~x01;
                        case x0A:
                            return ~x0A & x01;
                        case x0B:
                            return ~x0B | x01;
                        case x0C:
                            return ~x0C ^ x01;
                        case x0D:
                            return ~x0D & ~x01;
                        case x0E:
                            return ~x0E | ~x01;
                        case x0F:
                            return ~x0F ^ ~x01;
                    }
                    break;
                case x01:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & x02;
                        case x02:
                            return x02 | x02;
                        case x03:
                            return x03 ^ x02;
                        case x04:
                            return ~(x04 & x02);
                        case x05:
                            return ~(x05 | x02);
                        case x06:
                            return ~(x06 ^ x02);
                        case x07:
                            return x07 & ~x02;
                        case x08:
                            return x08 | ~x02;
                        case x09:
                            return x09 ^ ~x02;
                        case x0A:
                            return ~x0A & x02;
                        case x0B:
                            return ~x0B | x02;
                        case x0C:
                            return ~x0C ^ x02;
                        case x0D:
                            return ~x0D & ~x02;
                        case x0E:
                            return ~x0E | ~x02;
                        case x0F:
                            return ~x0F ^ ~x02;
                    }
                    break;
                case x02:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & x03;
                        case x02:
                            return x02 | x03;
                        case x03:
                            return x03 ^ x03;
                        case x04:
                            return ~(x04 & x03);
                        case x05:
                            return ~(x05 | x03);
                        case x06:
                            return ~(x06 ^ x03);
                        case x07:
                            return x07 & ~x03;
                        case x08:
                            return x08 | ~x03;
                        case x09:
                            return x09 ^ ~x03;
                        case x0A:
                            return ~x0A & x03;
                        case x0B:
                            return ~x0B | x03;
                        case x0C:
                            return ~x0C ^ x03;
                        case x0D:
                            return ~x0D & ~x03;
                        case x0E:
                            return ~x0E | ~x03;
                        case x0F:
                            return ~x0F ^ ~x03;
                    }
                    break;
                case x03:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x04:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x05:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x06:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x07:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x08:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x09:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x0A:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x0B:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x0C:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x0D:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x0E:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
                case x0F:
                    switch(dst)
                    {
                        case x00:
                            return 0;
                        case x01:
                            return x01 & dst;
                        case x02:
                            return x02 | dst;
                        case x03:
                            return x03 ^ dst;
                        case x04:
                            return ~(x04 & dst);
                        case x05:
                            return ~(x05 | dst);
                        case x06:
                            return ~(x06 ^ dst);
                        case x07:
                            return x07 & ~dst;
                        case x08:
                            return x08 | ~dst;
                        case x09:
                            return x09 ^ ~dst;
                        case x0A:
                            return ~x0A & dst;
                        case x0B:
                            return ~x0B | dst;
                        case x0C:
                            return ~x0C ^ dst;
                        case x0D:
                            return ~x0D & ~dst;
                        case x0E:
                            return ~x0E | ~dst;
                        case x0F:
                            return ~x0F ^ ~dst;
                    }
                    break;
            }

            return x0F;
        }

    }
}
