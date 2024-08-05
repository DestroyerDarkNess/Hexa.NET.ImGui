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

namespace Hexa.NET.ImGui
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextState
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiContext* Ctx;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ID;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int CurLenW;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int CurLenA;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<char> TextW;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<byte> TextA;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<byte> InitialTextA;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte TextAIsValid;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int BufCapacityA;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ScrollX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public STBTexteditState Stb;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float CursorAnim;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte CursorFollow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte SelectedAllMouseLock;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Edited;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiInputTextFlags Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte ReloadUserBuf;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int ReloadSelectionStart;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int ReloadSelectionEnd;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiInputTextState(ImGuiContextPtr ctx = default, uint id = default, int curLenW = default, int curLenA = default, ImVector<char> textW = default, ImVector<byte> textA = default, ImVector<byte> initialTextA = default, bool textAIsValid = default, int bufCapacityA = default, float scrollX = default, STBTexteditState stb = default, float cursorAnim = default, bool cursorFollow = default, bool selectedAllMouseLock = default, bool edited = default, ImGuiInputTextFlags flags = default, bool reloadUserBuf = default, int reloadSelectionStart = default, int reloadSelectionEnd = default)
		{
			Ctx = ctx;
			ID = id;
			CurLenW = curLenW;
			CurLenA = curLenA;
			TextW = textW;
			TextA = textA;
			InitialTextA = initialTextA;
			TextAIsValid = textAIsValid ? (byte)1 : (byte)0;
			BufCapacityA = bufCapacityA;
			ScrollX = scrollX;
			Stb = stb;
			CursorAnim = cursorAnim;
			CursorFollow = cursorFollow ? (byte)1 : (byte)0;
			SelectedAllMouseLock = selectedAllMouseLock ? (byte)1 : (byte)0;
			Edited = edited ? (byte)1 : (byte)0;
			Flags = flags;
			ReloadUserBuf = reloadUserBuf ? (byte)1 : (byte)0;
			ReloadSelectionStart = reloadSelectionStart;
			ReloadSelectionEnd = reloadSelectionEnd;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiInputTextStatePtr : IEquatable<ImGuiInputTextStatePtr>
	{
		public ImGuiInputTextStatePtr(ImGuiInputTextState* handle) { Handle = handle; }

		public ImGuiInputTextState* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiInputTextStatePtr Null => new ImGuiInputTextStatePtr(null);

		public ImGuiInputTextState this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiInputTextStatePtr(ImGuiInputTextState* handle) => new ImGuiInputTextStatePtr(handle);

		public static implicit operator ImGuiInputTextState*(ImGuiInputTextStatePtr handle) => handle.Handle;

		public static bool operator ==(ImGuiInputTextStatePtr left, ImGuiInputTextStatePtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiInputTextStatePtr left, ImGuiInputTextStatePtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiInputTextStatePtr left, ImGuiInputTextState* right) => left.Handle == right;

		public static bool operator !=(ImGuiInputTextStatePtr left, ImGuiInputTextState* right) => left.Handle != right;

		public bool Equals(ImGuiInputTextStatePtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiInputTextStatePtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiInputTextStatePtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiContextPtr Ctx => ref Unsafe.AsRef<ImGuiContextPtr>(&Handle->Ctx);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&Handle->ID);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int CurLenW => ref Unsafe.AsRef<int>(&Handle->CurLenW);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int CurLenA => ref Unsafe.AsRef<int>(&Handle->CurLenA);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<char> TextW => ref Unsafe.AsRef<ImVector<char>>(&Handle->TextW);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<byte> TextA => ref Unsafe.AsRef<ImVector<byte>>(&Handle->TextA);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<byte> InitialTextA => ref Unsafe.AsRef<ImVector<byte>>(&Handle->InitialTextA);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool TextAIsValid => ref Unsafe.AsRef<bool>(&Handle->TextAIsValid);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int BufCapacityA => ref Unsafe.AsRef<int>(&Handle->BufCapacityA);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ScrollX => ref Unsafe.AsRef<float>(&Handle->ScrollX);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref STBTexteditState Stb => ref Unsafe.AsRef<STBTexteditState>(&Handle->Stb);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float CursorAnim => ref Unsafe.AsRef<float>(&Handle->CursorAnim);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool CursorFollow => ref Unsafe.AsRef<bool>(&Handle->CursorFollow);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool SelectedAllMouseLock => ref Unsafe.AsRef<bool>(&Handle->SelectedAllMouseLock);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool Edited => ref Unsafe.AsRef<bool>(&Handle->Edited);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&Handle->Flags);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool ReloadUserBuf => ref Unsafe.AsRef<bool>(&Handle->ReloadUserBuf);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int ReloadSelectionStart => ref Unsafe.AsRef<int>(&Handle->ReloadSelectionStart);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int ReloadSelectionEnd => ref Unsafe.AsRef<int>(&Handle->ReloadSelectionEnd);
	}

}