//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    
    public partial struct Shell32
    {
        public const int SW_HIDE = 0;

        public const int SW_SHOWNORMAL = 1;
        
        public const int SW_SHOWMINIMIZED = 2;
        
        public const int SW_SHOWMAXIMIZED = 3;

        public const int SE_ERR_FNF = 2;
        
        public const int SE_ERR_PNF = 3;
        
        public const int SE_ERR_ACCESSDENIED = 5;
        
        public const int SE_ERR_OOM = 8;
        
        public const int SE_ERR_DLLNOTFOUND = 32;
        
        public const int SE_ERR_SHARE = 26;
        
        public const int SE_ERR_ASSOCINCOMPLETE = 27;
        
        public const int SE_ERR_DDETIMEOUT = 28;
        
        public const int SE_ERR_DDEFAIL = 29;
        
        public const int SE_ERR_DDEBUSY = 30;
        
        public const int SE_ERR_NOASSOC = 31;

        public const uint SEE_MASK_FLAG_DDEWAIT = 0x00000100;
        
        public const uint SEE_MASK_NOCLOSEPROCESS = 0x00000040;
        
        public const uint SEE_MASK_FLAG_NO_UI = 0x00000400;
    }
 
}