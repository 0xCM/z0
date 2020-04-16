//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppMsgWriter : IServiceAllocation
    {
        void Write<F>(F formattable)
            where F : ICustomFormattable;  

        void Write<F>(F[] formattables)
            where F : ICustomFormattable;  

        static IAppMsgWriter AllocateFile(FolderPath dst, string name, FileExtension ext = null, FileWriteMode mode = FileWriteMode.Overwrite,  bool display = false)
        {
            var target = dst + FileName.Define(name, ext ?? FileExtensions.Log);
            return AppMessages.writer(target, name, mode, display);
        }
    }
}