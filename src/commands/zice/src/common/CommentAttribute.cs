//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;

	[AttributeUsage(AttributeTargets.All)]
	public sealed class CommentAttribute : Attribute 
	{
		public string Comment { get; }
		public CommentAttribute(string comment) 
			=> Comment = comment ?? throw new InvalidOperationException();

		public static string GetDocumentation(MemberInfo member) =>
			((CommentAttribute)member.GetCustomAttribute(typeof(CommentAttribute)))?.Comment;
	}    

}