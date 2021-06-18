//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static Root;

    public partial class IntrinsicsModels
    {
        public static void render(Operation src, ITextBuffer dst)
        {
            if(src.Content != null)
                iter(src.Content, x => dst.AppendLine("  " + x.Content));
        }

        public static string format(Instruction src)
             => string.Format("# Instruction: {0} {1}\r\n", src.name, src.form) + string.Format("# Iform: {0}", src.xed);

        public static void render(Instructions src, ITextBuffer dst)
            => iter(src, x => dst.AppendLine(format(x)));

        public static string sig(Intrinsic src)
            => string.Format("{0} {1}({2})", src.@return,  src.name,  string.Join(", ", src.parameters.ToArray()));

        public static void body(Intrinsic src, ITextBuffer dst)
        {
            dst.AppendLine("{");
            render(src.operation, dst);
            dst.AppendLine("}");
        }

        public static string format(Intrinsic src)
        {
            var dst = TextTools.buffer();
            overview(src, dst);
            body(src, dst);
            return dst.Emit();
        }

        public static void overview(Intrinsic src, ITextBuffer dst)
        {
            dst.AppendLine(string.Format("# Intrinsic: {0}", sig(src)));

            var classes = list<string>(3);
            if(nonempty(src.tech))
                classes.Add(src.tech);
            if(src.CPUID.IsNonEmpty)
                classes.Add(src.CPUID.Content);
            if(src.category.IsNonEmpty)
                classes.Add(src.category.Content);
            if(classes.Count != 0)
                dst.AppendLineFormat("# Classification: {0}", string.Join(", ", classes));

            render(src.instructions, dst);
            dst.AppendLineFormat("# Description: {0}", src.description);
        }
    }
}