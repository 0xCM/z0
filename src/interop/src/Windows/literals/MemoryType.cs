// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
   public enum MemoryType : uint
   {
        /// <summary>
        /// Indicates that the memory pages within the region are mapped into the view of an image section.
        /// </summary>
        MEM_IMAGE = 0x1000000,

        /// <summary>
        /// Indicates that the memory pages within the region are mapped into the view of a section.
        /// </summary>
        MEM_MAPPED = 0x40000,

        /// <summary>
        /// Indicates that the memory pages within the region are private (that is, not shared by other processes).
        /// </summary>
        MEM_PRIVATE = 0x20000

    }
}