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

namespace Hexa.NET.ImPlot
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTagCollection
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<ImPlotTag> Tags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiTextBuffer TextBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int Size;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPlotTagCollection(ImVector<ImPlotTag> tags = default, ImGuiTextBuffer textBuffer = default, int size = default)
		{
			Tags = tags;
			TextBuffer = textBuffer;
			Size = size;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImPlotTagCollectionPtr : IEquatable<ImPlotTagCollectionPtr>
	{
		public ImPlotTagCollectionPtr(ImPlotTagCollection* handle) { Handle = handle; }

		public ImPlotTagCollection* Handle;

		public bool IsNull => Handle == null;

		public static ImPlotTagCollectionPtr Null => new ImPlotTagCollectionPtr(null);

		public ImPlotTagCollection this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImPlotTagCollectionPtr(ImPlotTagCollection* handle) => new ImPlotTagCollectionPtr(handle);

		public static implicit operator ImPlotTagCollection*(ImPlotTagCollectionPtr handle) => handle.Handle;

		public static bool operator ==(ImPlotTagCollectionPtr left, ImPlotTagCollectionPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImPlotTagCollectionPtr left, ImPlotTagCollectionPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImPlotTagCollectionPtr left, ImPlotTagCollection* right) => left.Handle == right;

		public static bool operator !=(ImPlotTagCollectionPtr left, ImPlotTagCollection* right) => left.Handle != right;

		public bool Equals(ImPlotTagCollectionPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImPlotTagCollectionPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImPlotTagCollectionPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<ImPlotTag> Tags => ref Unsafe.AsRef<ImVector<ImPlotTag>>(&Handle->Tags);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&Handle->TextBuffer);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int Size => ref Unsafe.AsRef<int>(&Handle->Size);
	}

}