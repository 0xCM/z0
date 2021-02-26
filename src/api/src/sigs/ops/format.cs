//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiSigs
    {
        [Op]
        public static string format(OperationSig src)
        {
            var dst = buffer();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static string format(TypeSig src)
        {
            var dst = buffer();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        static ITextBuffer buffer(uint capacity = 120)
            => text.buffer(capacity);
    }
}