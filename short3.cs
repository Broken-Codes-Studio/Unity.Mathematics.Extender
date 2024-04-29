using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics.Extender
{
    /// <summary>A 3 component vector of shorts.</summary>
    [DebuggerTypeProxy(typeof(short3.DebuggerProxy))]
    [System.Serializable]
    public partial struct short3 : System.IEquatable<short3>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public short x;
        /// <summary>y component of the vector.</summary>
        public short y;
        /// <summary>z component of the vector.</summary>
        public short z;

        /// <summary>short3 zero value.</summary>
        public static readonly short3 zero;

        /// <summary>Constructs a short3 vector from three short values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(byte x, byte y, byte z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public short3(short x, short y, short z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public short3(int x, int y, int z)
        {
            this.x = (short)x;
            this.y = (short)y;
            this.z = (short)z;
        }

        /// <summary>Constructs a short3 vector from a short value and a short2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(short x, short2 yz)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a short3 vector from a short2 vector and a short value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(short2 xy, short z)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a short3 vector from a short3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(short3 xyz)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a short3 vector from a single short value by assigning it to every component.</summary>
        /// <param name="v">short to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(short v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a short3 vector from a single byte value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">byte to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(byte v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a short3 vector from a byte3 vector by componentwise conversion.</summary>
        /// <param name="v">byte3 to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(byte3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>Constructs a short3 vector from a single half value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">half to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(half v)
        {
            this.x = (short)v;
            this.y = (short)v;
            this.z = (short)v;
        }

        /// <summary>Constructs a short3 vector from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(half3 v)
        {
            this.x = (short)v.x;
            this.y = (short)v.y;
            this.z = (short)v.z;
        }

        /// <summary>Constructs a short3 vector from a single int value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">int to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(int v)
        {
            this.x = (short)v;
            this.y = (short)v;
            this.z = (short)v;
        }

        /// <summary>Constructs a short3 vector from an int3 vector by componentwise conversion.</summary>
        /// <param name="v">int3 to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(int3 v)
        {
            this.x = (short)v.x;
            this.y = (short)v.y;
            this.z = (short)v.z;
        }

        /// <summary>Constructs a short3 vector from a single float value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">float to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(float v)
        {
            this.x = (short)v;
            this.y = (short)v;
            this.z = (short)v;
        }

        /// <summary>Constructs a short3 vector from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(float3 v)
        {
            this.x = (short)v.x;
            this.y = (short)v.y;
            this.z = (short)v.z;
        }

        /// <summary>Constructs a short3 vector from a single double value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">double to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(double v)
        {
            this.x = (short)v;
            this.y = (short)v;
            this.z = (short)v;
        }

        /// <summary>Constructs a short3 vector from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to short3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3(double3 v)
        {
            this.x = (short)v.x;
            this.y = (short)v.y;
            this.z = (short)v.z;
        }


        /// <summary>Implicitly converts a single short value to a short3 vector by assigning it to every component.</summary>
        /// <param name="v">short to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short3(short v) { return new short3(v); }

        /// <summary>Explicitly converts a single byte value to a short3 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">byte to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(byte v) { return new short3(v); }

        /// <summary>Explicitly converts a byte3 vector to a short3 vector by componentwise conversion.</summary>
        /// <param name="v">byte3 to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(byte3 v) { return new short3(v); }

        /// <summary>Explicitly converts a single half value to a short3 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">half to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(half v) { return new short3(v); }

        /// <summary>Explicitly converts a half3 vector to a short3 vector by componentwise conversion.</summary>
        /// <param name="v">half3 to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(half3 v) { return new short3(v); }

        /// <summary>Explicitly converts a single int value to a short3 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">int to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(int v) { return new short3(v); }

        /// <summary>Explicitly converts an int3 vector to a short3 vector by componentwise conversion.</summary>
        /// <param name="v">int3 to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(int3 v) { return new short3(v); }

        /// <summary>Explicitly converts a single float value to a short3 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">float to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(float v) { return new short3(v); }

        /// <summary>Explicitly converts a float3 vector to a short3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(float3 v) { return new short3(v); }

        /// <summary>Explicitly converts a single double value to a short3 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">double to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(double v) { return new short3(v); }

        /// <summary>Explicitly converts a double3 vector to a short3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(double3 v) { return new short3(v); }

        /// <summary>Returns the result of a componentwise multiplication operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise multiplication.</param>
        /// <returns>short3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator *(short3 lhs, short3 rhs) { return new short3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float3 vector and a short3 value.</summary>
        /// <param name="lhs">Left hand side float3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise multiplication.</param>
        /// <returns>short3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator *(float3 lhs, short3 rhs) { return new float3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on a short3 vector and a float3 value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float3 to use to compute componentwise multiplication.</param>
        /// <returns>short3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator *(short3 lhs, float3 rhs) { return new float3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on a short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise multiplication.</param>
        /// <returns>short3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator *(short3 lhs, int rhs) { return new short3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise multiplication.</param>
        /// <returns>short3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator *(int lhs, short3 rhs) { return new short3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }


        /// <summary>Returns the result of a componentwise addition operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise addition.</param>
        /// <returns>short3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator +(short3 lhs, short3 rhs) { return new short3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise addition.</param>
        /// <returns>short3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator +(short3 lhs, int rhs) { return new short3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise addition.</param>
        /// <returns>short3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator +(int lhs, short3 rhs) { return new short3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise subtraction.</param>
        /// <returns>short3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator -(short3 lhs, short3 rhs) { return new short3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise subtraction.</param>
        /// <returns>short3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator -(short3 lhs, int rhs) { return new short3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise subtraction.</param>
        /// <returns>short3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator -(int lhs, short3 rhs) { return new short3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise division.</param>
        /// <returns>short3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator /(short3 lhs, short3 rhs) { return new short3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise division.</param>
        /// <returns>short3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator /(short3 lhs, int rhs) { return new short3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise division.</param>
        /// <returns>short3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator /(int lhs, short3 rhs) { return new short3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise modulus.</param>
        /// <returns>short3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator %(short3 lhs, short3 rhs) { return new short3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise modulus.</param>
        /// <returns>short3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator %(short3 lhs, int rhs) { return new short3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise modulus.</param>
        /// <returns>short3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator %(int lhs, short3 rhs) { return new short3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on an short3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>short3 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator ++(short3 val) { return new short3(++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on an short3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>short3 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator --(short3 val) { return new short3(--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <(short3 lhs, short3 rhs) { return new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <(short3 lhs, int rhs) { return new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <(int lhs, short3 rhs) { return new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <=(short3 lhs, short3 rhs) { return new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <=(short3 lhs, int rhs) { return new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <=(int lhs, short3 rhs) { return new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >(short3 lhs, short3 rhs) { return new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >(short3 lhs, int rhs) { return new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >(int lhs, short3 rhs) { return new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >=(short3 lhs, short3 rhs) { return new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an short3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >=(short3 lhs, int rhs) { return new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an short3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >=(int lhs, short3 rhs) { return new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on an short3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>short3 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator -(short3 val) { return new short3(-val.x, -val.y, -val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on an short3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>short3 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator +(short3 val) { return new short3(+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise left shift operation on an short3 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator <<(short3 x, int n) { return new short3(x.x << n, x.y << n, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an short3 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 operator >>(short3 x, int n) { return new short3(x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two short3short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ==(short3 lhs, short3 rhs) { return new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on a short3 vector and a short value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ==(short3 lhs, short rhs) { return new bool3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a short value and a short3 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ==(short lhs, short3 rhs) { return new bool3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two short3 vectors.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator !=(short3 lhs, short3 rhs) { return new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on a short3 vector and a short value.</summary>
        /// <param name="lhs">Left hand side short3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator !=(short3 lhs, short rhs) { return new bool3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a short value and a short3 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side short3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator !=(short lhs, short3 rhs) { return new bool3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }




        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(z, z); }
        }



        /// <summary>Returns the short element at a specified index.</summary>
        unsafe public short this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (short3* array = &this) { return ((short*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (short* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the short3 is equal to a given short3, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(short3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the short3 is equal to a given short3, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is short3 converted && Equals(converted); }


        /// <summary>Returns a hash code for the short3.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)mathExtended.hash(this); }


        /// <summary>Returns a string representation of the short3.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("short3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the short3 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("short3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public short x;
            public short y;
            public short z;
            public DebuggerProxy(short3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class mathExtended
    {
        /// <summary>Returns a short3 vector constructed from three short values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>short3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(short x, short y, short z) { return new short3(x, y, z); }

        /// <summary>Returns a short3 vector constructed from a short value and a short2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <returns>short3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(short x, short2 yz) { return new short3(x, yz); }

        /// <summary>Returns a short3 vector constructed from a short2 vector and a short value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>short3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(short2 xy, short z) { return new short3(xy, z); }

        /// <summary>Returns a short3 vector constructed from a short3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <returns>short3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(short3 xyz) { return new short3(xyz); }

        /// <summary>Returns a short3 vector constructed from a single short value by assigning it to every component.</summary>
        /// <param name="v">short to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(short v) { return new short3(v); }

        /// <summary>Returns a short3 vector constructed from a single float value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">float to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(float v) { return new short3(v); }

        /// <summary>Return a short3 vector constructed from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(float3 v) { return new short3(v); }

        /// <summary>Returns a short3 vector constructed from a single double value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">double to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(double v) { return new short3(v); }

        /// <summary>Return a short3 vector constructed from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to short3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 short3(double3 v) { return new short3(v); }

        /// <summary>Return a half3 vector constructed from a short3 vector by componentwise conversion.</summary>
        /// <param name="v">short3 to convert to half3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 half3(short3 v) { return (half3)float3(v); }

        /// <summary>Return a half3 vector constructed from a short3 vector by componentwise conversion.</summary>
        /// <param name="v">short3 to convert to half3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(short3 v) { return new float3(v.x, v.y, v.z); }

        /// <summary>Returns the dot product of two half3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half dot(half3 x, half3 y) { return new half(x.x * y.x + x.y * y.y + x.z * y.z); }

        /// <summary>Returns the square root of a float value.</summary>
        /// <param name="x">Value to use when computing square root.</param>
        /// <returns>The square root.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sqrt(half x) { return (half)System.Math.Sqrt((half)x); }

        /// <summary>Returns the length of a float3 vector.</summary>
        /// <param name="x">Vector to use when computing length.</param>
        /// <returns>Length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float length(half3 x) { return sqrt(dot(x, x)); }

        /// <summary>Returns the squared length of a half3 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half lengthsq(half3 x) { return dot(x, x); }

        /// <summary>Returns the dot product of two short3 vectors.</summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The dot product of two vectors.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half dot(short3 x, short3 y) { return new half(x.x * y.x + x.y * y.y + x.z * y.z); }

        /// <summary>Returns the squared length of a short3 vector.</summary>
        /// <param name="x">Vector to use when computing squared length.</param>
        /// <returns>Squared length of vector x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half lengthsq(short3 x) { return dot(x, x); }

        /// <summary>Returns a uint hash code of a short3 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(short3 v)
        {
            return Mathematics.math.csum(new uint3((uint)v.x, (uint)v.y, (uint)v.z) * new uint3(0x685835CFu, 0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a short3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint3 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(short3 v)
        {
            return (new uint3((uint)v.x, (uint)v.y, (uint)v.z) * new uint3(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u)) + 0x94DDD769u;
        }

    }
}
