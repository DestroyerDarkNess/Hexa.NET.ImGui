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
	/// Stacked style modifier, backup of modified data so we can restore it. Data type inferred from the variable.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyleMod
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ImGuiStyleModUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public int BackupInt_0;
			[FieldOffset(8)]
			public int BackupInt_1;

			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public float BackupFloat_0;
			[FieldOffset(8)]
			public float BackupFloat_1;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe ImGuiStyleModUnion(int* backupInt = default, float* backupFloat = default)
			{
				if (backupInt != default(int*))
				{
					BackupInt_0 = backupInt[0];
					BackupInt_1 = backupInt[1];
				}
				if (backupFloat != default(float*))
				{
					BackupFloat_0 = backupFloat[0];
					BackupFloat_1 = backupFloat[1];
				}
			}

			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe ImGuiStyleModUnion(Span<int> backupInt = default, Span<float> backupFloat = default)
			{
				if (backupInt != default(Span<int>))
				{
					BackupInt_0 = backupInt[0];
					BackupInt_1 = backupInt[1];
				}
				if (backupFloat != default(Span<float>))
				{
					BackupFloat_0 = backupFloat[0];
					BackupFloat_1 = backupFloat[1];
				}
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiStyleVar VarIdx;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiStyleModUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiStyleMod(ImGuiStyleVar varIdx = default, ImGuiStyleModUnion union = default)
		{
			VarIdx = varIdx;
			Union = union;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiStyleModPtr : IEquatable<ImGuiStyleModPtr>
	{
		public ImGuiStyleModPtr(ImGuiStyleMod* handle) { Handle = handle; }

		public ImGuiStyleMod* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiStyleModPtr Null => new ImGuiStyleModPtr(null);

		public ImGuiStyleMod this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* handle) => new ImGuiStyleModPtr(handle);

		public static implicit operator ImGuiStyleMod*(ImGuiStyleModPtr handle) => handle.Handle;

		public static bool operator ==(ImGuiStyleModPtr left, ImGuiStyleModPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiStyleModPtr left, ImGuiStyleModPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiStyleModPtr left, ImGuiStyleMod* right) => left.Handle == right;

		public static bool operator !=(ImGuiStyleModPtr left, ImGuiStyleMod* right) => left.Handle != right;

		public bool Equals(ImGuiStyleModPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiStyleModPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiStyleModPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&Handle->VarIdx);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiStyleMod.ImGuiStyleModUnion Union => ref Unsafe.AsRef<ImGuiStyleMod.ImGuiStyleModUnion>(&Handle->Union);
	}

}
