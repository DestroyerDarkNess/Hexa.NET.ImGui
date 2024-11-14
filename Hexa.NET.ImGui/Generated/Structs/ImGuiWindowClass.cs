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
	/// [ALPHA] Rarely used  very advanced uses only. Use with SetNextWindowClass() and DockSpace() functions.<br/>
	/// Important: the content of this class is still highly WIP and likely to change and be refactored<br/>
	/// before we stabilize Docking features. Please be mindful if using this.<br/>
	/// Provide hints:<br/>
	/// - To the platform backend via altered viewport flags (enabledisable OS decoration, OS task bar icons, etc.)<br/>
	/// - To the platform backend for OS level parentchild relationships of viewport.<br/>
	/// - To the docking system for various options and filtering.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowClass
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ClassId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ParentViewportId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint FocusRouteParentWindowId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiViewportFlags ViewportFlagsOverrideSet;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiViewportFlags ViewportFlagsOverrideClear;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiTabItemFlags TabItemFlagsOverrideSet;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiDockNodeFlags DockNodeFlagsOverrideSet;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte DockingAlwaysTabBar;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte DockingAllowUnclassed;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiWindowClass(uint classId = default, uint parentViewportId = default, uint focusRouteParentWindowId = default, ImGuiViewportFlags viewportFlagsOverrideSet = default, ImGuiViewportFlags viewportFlagsOverrideClear = default, ImGuiTabItemFlags tabItemFlagsOverrideSet = default, ImGuiDockNodeFlags dockNodeFlagsOverrideSet = default, bool dockingAlwaysTabBar = default, bool dockingAllowUnclassed = default)
		{
			ClassId = classId;
			ParentViewportId = parentViewportId;
			FocusRouteParentWindowId = focusRouteParentWindowId;
			ViewportFlagsOverrideSet = viewportFlagsOverrideSet;
			ViewportFlagsOverrideClear = viewportFlagsOverrideClear;
			TabItemFlagsOverrideSet = tabItemFlagsOverrideSet;
			DockNodeFlagsOverrideSet = dockNodeFlagsOverrideSet;
			DockingAlwaysTabBar = dockingAlwaysTabBar ? (byte)1 : (byte)0;
			DockingAllowUnclassed = dockingAllowUnclassed ? (byte)1 : (byte)0;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (ImGuiWindowClass* @this = &this)
			{
				ImGui.DestroyNative(@this);
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiWindowClassPtr : IEquatable<ImGuiWindowClassPtr>
	{
		public ImGuiWindowClassPtr(ImGuiWindowClass* handle) { Handle = handle; }

		public ImGuiWindowClass* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiWindowClassPtr Null => new ImGuiWindowClassPtr(null);

		public ImGuiWindowClass this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiWindowClassPtr(ImGuiWindowClass* handle) => new ImGuiWindowClassPtr(handle);

		public static implicit operator ImGuiWindowClass*(ImGuiWindowClassPtr handle) => handle.Handle;

		public static bool operator ==(ImGuiWindowClassPtr left, ImGuiWindowClassPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiWindowClassPtr left, ImGuiWindowClassPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiWindowClassPtr left, ImGuiWindowClass* right) => left.Handle == right;

		public static bool operator !=(ImGuiWindowClassPtr left, ImGuiWindowClass* right) => left.Handle != right;

		public bool Equals(ImGuiWindowClassPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiWindowClassPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiWindowClassPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint ClassId => ref Unsafe.AsRef<uint>(&Handle->ClassId);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint ParentViewportId => ref Unsafe.AsRef<uint>(&Handle->ParentViewportId);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint FocusRouteParentWindowId => ref Unsafe.AsRef<uint>(&Handle->FocusRouteParentWindowId);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiViewportFlags ViewportFlagsOverrideSet => ref Unsafe.AsRef<ImGuiViewportFlags>(&Handle->ViewportFlagsOverrideSet);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiViewportFlags ViewportFlagsOverrideClear => ref Unsafe.AsRef<ImGuiViewportFlags>(&Handle->ViewportFlagsOverrideClear);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiTabItemFlags TabItemFlagsOverrideSet => ref Unsafe.AsRef<ImGuiTabItemFlags>(&Handle->TabItemFlagsOverrideSet);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiDockNodeFlags DockNodeFlagsOverrideSet => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&Handle->DockNodeFlagsOverrideSet);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool DockingAlwaysTabBar => ref Unsafe.AsRef<bool>(&Handle->DockingAlwaysTabBar);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool DockingAllowUnclassed => ref Unsafe.AsRef<bool>(&Handle->DockingAllowUnclassed);
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			ImGui.DestroyNative(Handle);
		}

	}

}
