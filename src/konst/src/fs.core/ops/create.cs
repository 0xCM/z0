//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    partial struct FS
    {
        /// <summary>
        /// Creates the specified folder if it does not exist; if it already exists, the file system is unmodified.
        /// </summary>
        /// <param name="dst">The source path</param>
        /// <remarks>The operation is idempotent</remarks>
        [MethodImpl(Inline), Op]
        public static FolderPath create(FolderPath dst)
        {
            void f()
            {
                if(!Directory.Exists(dst.Name))
                    Directory.CreateDirectory(dst.Name);
            }

            var result = Try(f);
            return result.Ok ? dst : FolderPath.Empty;
        }

        static Outcome<string> Try(Action f)
        {
            try
            {
                f();
                return Eval.success(EmptyString);
            }
            catch(Exception e)
            {
                term.error(e);
                return Eval.fail(e.ToString());
            }
        }
    }
}