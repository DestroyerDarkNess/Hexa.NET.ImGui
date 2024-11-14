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
	public partial struct ImPlotNextItemData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float LineWeight;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImPlotMarker Marker;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float MarkerSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float MarkerWeight;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float FillAlpha;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ErrorBarSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ErrorBarWeight;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float DigitalBitHeight;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float DigitalBitGap;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte RenderLine;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte RenderFill;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte RenderMarkerLine;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte RenderMarkerFill;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte HasHidden;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Hidden;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImPlotCond HiddenCond;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPlotNextItemData(Vector4* colors = default, float lineWeight = default, ImPlotMarker marker = default, float markerSize = default, float markerWeight = default, float fillAlpha = default, float errorBarSize = default, float errorBarWeight = default, float digitalBitHeight = default, float digitalBitGap = default, bool renderLine = default, bool renderFill = default, bool renderMarkerLine = default, bool renderMarkerFill = default, bool hasHidden = default, bool hidden = default, ImPlotCond hiddenCond = default)
		{
			if (colors != default(Vector4*))
			{
				Colors_0 = colors[0];
				Colors_1 = colors[1];
				Colors_2 = colors[2];
				Colors_3 = colors[3];
				Colors_4 = colors[4];
			}
			LineWeight = lineWeight;
			Marker = marker;
			MarkerSize = markerSize;
			MarkerWeight = markerWeight;
			FillAlpha = fillAlpha;
			ErrorBarSize = errorBarSize;
			ErrorBarWeight = errorBarWeight;
			DigitalBitHeight = digitalBitHeight;
			DigitalBitGap = digitalBitGap;
			RenderLine = renderLine ? (byte)1 : (byte)0;
			RenderFill = renderFill ? (byte)1 : (byte)0;
			RenderMarkerLine = renderMarkerLine ? (byte)1 : (byte)0;
			RenderMarkerFill = renderMarkerFill ? (byte)1 : (byte)0;
			HasHidden = hasHidden ? (byte)1 : (byte)0;
			Hidden = hidden ? (byte)1 : (byte)0;
			HiddenCond = hiddenCond;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPlotNextItemData(Span<Vector4> colors = default, float lineWeight = default, ImPlotMarker marker = default, float markerSize = default, float markerWeight = default, float fillAlpha = default, float errorBarSize = default, float errorBarWeight = default, float digitalBitHeight = default, float digitalBitGap = default, bool renderLine = default, bool renderFill = default, bool renderMarkerLine = default, bool renderMarkerFill = default, bool hasHidden = default, bool hidden = default, ImPlotCond hiddenCond = default)
		{
			if (colors != default(Span<Vector4>))
			{
				Colors_0 = colors[0];
				Colors_1 = colors[1];
				Colors_2 = colors[2];
				Colors_3 = colors[3];
				Colors_4 = colors[4];
			}
			LineWeight = lineWeight;
			Marker = marker;
			MarkerSize = markerSize;
			MarkerWeight = markerWeight;
			FillAlpha = fillAlpha;
			ErrorBarSize = errorBarSize;
			ErrorBarWeight = errorBarWeight;
			DigitalBitHeight = digitalBitHeight;
			DigitalBitGap = digitalBitGap;
			RenderLine = renderLine ? (byte)1 : (byte)0;
			RenderFill = renderFill ? (byte)1 : (byte)0;
			RenderMarkerLine = renderMarkerLine ? (byte)1 : (byte)0;
			RenderMarkerFill = renderMarkerFill ? (byte)1 : (byte)0;
			HasHidden = hasHidden ? (byte)1 : (byte)0;
			Hidden = hidden ? (byte)1 : (byte)0;
			HiddenCond = hiddenCond;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<Vector4> Colors
		
		{
			get
			{
				fixed (Vector4* p = &this.Colors_0)
				{
					return new Span<Vector4>(p, 5);
				}
			}
		}
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (ImPlotNextItemData* @this = &this)
			{
				ImPlot.DestroyNative(@this);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Reset()
		{
			fixed (ImPlotNextItemData* @this = &this)
			{
				ImPlot.ResetNative(@this);
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImPlotNextItemDataPtr : IEquatable<ImPlotNextItemDataPtr>
	{
		public ImPlotNextItemDataPtr(ImPlotNextItemData* handle) { Handle = handle; }

		public ImPlotNextItemData* Handle;

		public bool IsNull => Handle == null;

		public static ImPlotNextItemDataPtr Null => new ImPlotNextItemDataPtr(null);

		public ImPlotNextItemData this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImPlotNextItemDataPtr(ImPlotNextItemData* handle) => new ImPlotNextItemDataPtr(handle);

		public static implicit operator ImPlotNextItemData*(ImPlotNextItemDataPtr handle) => handle.Handle;

		public static bool operator ==(ImPlotNextItemDataPtr left, ImPlotNextItemDataPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImPlotNextItemDataPtr left, ImPlotNextItemDataPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImPlotNextItemDataPtr left, ImPlotNextItemData* right) => left.Handle == right;

		public static bool operator !=(ImPlotNextItemDataPtr left, ImPlotNextItemData* right) => left.Handle != right;

		public bool Equals(ImPlotNextItemDataPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImPlotNextItemDataPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImPlotNextItemDataPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<Vector4> Colors
		
		{
			get
			{
				return new Span<Vector4>(&Handle->Colors_0, 5);
			}
		}
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float LineWeight => ref Unsafe.AsRef<float>(&Handle->LineWeight);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImPlotMarker Marker => ref Unsafe.AsRef<ImPlotMarker>(&Handle->Marker);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float MarkerSize => ref Unsafe.AsRef<float>(&Handle->MarkerSize);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float MarkerWeight => ref Unsafe.AsRef<float>(&Handle->MarkerWeight);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float FillAlpha => ref Unsafe.AsRef<float>(&Handle->FillAlpha);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ErrorBarSize => ref Unsafe.AsRef<float>(&Handle->ErrorBarSize);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ErrorBarWeight => ref Unsafe.AsRef<float>(&Handle->ErrorBarWeight);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float DigitalBitHeight => ref Unsafe.AsRef<float>(&Handle->DigitalBitHeight);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float DigitalBitGap => ref Unsafe.AsRef<float>(&Handle->DigitalBitGap);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool RenderLine => ref Unsafe.AsRef<bool>(&Handle->RenderLine);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool RenderFill => ref Unsafe.AsRef<bool>(&Handle->RenderFill);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool RenderMarkerLine => ref Unsafe.AsRef<bool>(&Handle->RenderMarkerLine);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool RenderMarkerFill => ref Unsafe.AsRef<bool>(&Handle->RenderMarkerFill);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool HasHidden => ref Unsafe.AsRef<bool>(&Handle->HasHidden);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool Hidden => ref Unsafe.AsRef<bool>(&Handle->Hidden);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImPlotCond HiddenCond => ref Unsafe.AsRef<ImPlotCond>(&Handle->HiddenCond);
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			ImPlot.DestroyNative(Handle);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Reset()
		{
			ImPlot.ResetNative(Handle);
		}

	}

}
