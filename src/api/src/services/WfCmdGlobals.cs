//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using K = GlobalWfCmd;

    public enum GlobalWfCmd : ushort
    {
        None,

        ShowByteConversions,
    }

    public class WfCmdGlobals : WfCmdHost<WfCmdGlobals, GlobalWfCmd>
    {
        protected override void RegisterCommands(WfCmdIndex index)
        {
            var count = GetType().DeclaredInstanceMethods().Tagged<ActionAttribute>(out var methods);
            if(count != 0)
            {
                var view = methods.View;
                for(var i=0; i<count; i++)
                {
                    ref readonly var method = ref skip(view,i);
                    index.Include(WfCmd.assign((GlobalWfCmd)method.Tag.Key, (Action)method.Method.CreateDelegate(typeof(Action),this)));
                }
            }
        }

        [Action(K.ShowByteConversions)]
        void ShowByteConversions()
        {
            const string FormatPattern = "{0,-5} | {1,-5} | {2}";

            var header = string.Format(FormatPattern, "Dec", "Hex", "Bits");
            using var logger = Db.ShowLog(ext:FS.Extensions.Csv).Writer();
            Wf.Row(header);
            logger.WriteLine(header);
            var options = BitFormatOptions.bitblock(4, Chars.Space);
            for(var i=0; i<= byte.MaxValue; i++)
            {
                byte src = (byte)i;
                var dec = string.Format("{0:D3}", src);
                var bits = src.FormatBits(options);
                var hex = src.FormatHex(specifier:false);
                var row = string.Format(FormatPattern, dec, hex, bits);
                logger.WriteLine(row);
                Wf.Row(row);
            }
        }
    }
}