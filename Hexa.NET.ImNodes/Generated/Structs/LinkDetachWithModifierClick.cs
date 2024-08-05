// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;
using Hexa.NET.ImGui;

namespace Hexa.NET.ImNodes
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct LinkDetachWithModifierClick
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe bool* Modifier;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe LinkDetachWithModifierClick(bool* modifier = default)
		{
			Modifier = modifier;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (LinkDetachWithModifierClick* @this = &this)
			{
				ImNodes.DestroyNative(@this);
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct LinkDetachWithModifierClickPtr : IEquatable<LinkDetachWithModifierClickPtr>
	{
		public LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* handle) { Handle = handle; }

		public LinkDetachWithModifierClick* Handle;

		public bool IsNull => Handle == null;

		public static LinkDetachWithModifierClickPtr Null => new LinkDetachWithModifierClickPtr(null);

		public LinkDetachWithModifierClick this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* handle) => new LinkDetachWithModifierClickPtr(handle);

		public static implicit operator LinkDetachWithModifierClick*(LinkDetachWithModifierClickPtr handle) => handle.Handle;

		public static bool operator ==(LinkDetachWithModifierClickPtr left, LinkDetachWithModifierClickPtr right) => left.Handle == right.Handle;

		public static bool operator !=(LinkDetachWithModifierClickPtr left, LinkDetachWithModifierClickPtr right) => left.Handle != right.Handle;

		public static bool operator ==(LinkDetachWithModifierClickPtr left, LinkDetachWithModifierClick* right) => left.Handle == right;

		public static bool operator !=(LinkDetachWithModifierClickPtr left, LinkDetachWithModifierClick* right) => left.Handle != right;

		public bool Equals(LinkDetachWithModifierClickPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LinkDetachWithModifierClickPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("LinkDetachWithModifierClickPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public bool* Modifier { get => Handle->Modifier; set => Handle->Modifier = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			ImNodes.DestroyNative(Handle);
		}

	}

}