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
	public partial struct ImPlotDateTimeSpec
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ImPlotDateFmt Date;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImPlotTimeFmt Time;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte UseISO8601;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Use24HourClock;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPlotDateTimeSpec(ImPlotDateFmt date = default, ImPlotTimeFmt time = default, bool useIso8601 = default, bool use24HourClock = default)
		{
			Date = date;
			Time = time;
			UseISO8601 = useIso8601 ? (byte)1 : (byte)0;
			Use24HourClock = use24HourClock ? (byte)1 : (byte)0;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImPlotDateTimeSpecPtr : IEquatable<ImPlotDateTimeSpecPtr>
	{
		public ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* handle) { Handle = handle; }

		public ImPlotDateTimeSpec* Handle;

		public bool IsNull => Handle == null;

		public static ImPlotDateTimeSpecPtr Null => new ImPlotDateTimeSpecPtr(null);

		public ImPlotDateTimeSpec this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* handle) => new ImPlotDateTimeSpecPtr(handle);

		public static implicit operator ImPlotDateTimeSpec*(ImPlotDateTimeSpecPtr handle) => handle.Handle;

		public static bool operator ==(ImPlotDateTimeSpecPtr left, ImPlotDateTimeSpecPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImPlotDateTimeSpecPtr left, ImPlotDateTimeSpecPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImPlotDateTimeSpecPtr left, ImPlotDateTimeSpec* right) => left.Handle == right;

		public static bool operator !=(ImPlotDateTimeSpecPtr left, ImPlotDateTimeSpec* right) => left.Handle != right;

		public bool Equals(ImPlotDateTimeSpecPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImPlotDateTimeSpecPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImPlotDateTimeSpecPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImPlotDateFmt Date => ref Unsafe.AsRef<ImPlotDateFmt>(&Handle->Date);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImPlotTimeFmt Time => ref Unsafe.AsRef<ImPlotTimeFmt>(&Handle->Time);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool UseISO8601 => ref Unsafe.AsRef<bool>(&Handle->UseISO8601);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool Use24HourClock => ref Unsafe.AsRef<bool>(&Handle->Use24HourClock);
	}

}