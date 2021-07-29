//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".xed-query")]
        Outcome XedForms(CmdArgs args)
        {
            const string RenderPattern = "class:{0,-24} form:{1,-32} category:{2,-16} isa:{3,-16} ext:{4,-16} attribs:{5}";
            var src = Xed.LoadForms();
            var _types = Xed.FormTypes();
            var _cats = Xed.Categories();
            var _isa = Xed.IsaKinds();
            var _classes = Xed.Classes();
            var _ext = Xed.IsaExtensions();
            var _classKinds = _classes.Kinds;
            var monic = arg(args,0).Value;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var form = ref skip(src,i);
                ref readonly var @class = ref _classes[form.Class];
                ref readonly var type = ref _types[form.Form];
                ref readonly var isa = ref _isa[form.IsaKind];
                ref readonly var ext = ref _ext[form.Extension];
                ref readonly var cat = ref _cats[form.Category];
                if(@class.Expr.Format().StartsWith(monic, StringComparison.InvariantCultureIgnoreCase))
                {
                    string fmt = string.Format(RenderPattern, @class.Expr, type.Expr, cat.Expr, isa.Expr, ext.Expr, form.Attributes);
                    Write(fmt);
                }
            }
            return true;
        }
    }
}