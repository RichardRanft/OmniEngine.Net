﻿#region

using System;
using System.ComponentModel;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Properties;

#endregion

namespace WinterLeaf.Engine.Containers
    {
    public class Point3FIConverter : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof(string) == sourceType);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            object value)
            {
            if (value is string)
                {
                return new Point3F(value as string);
                }

            return null;
            }
        }


    [TypeConverter(typeof(Point3FIConverter))]
    public sealed class Point3F : IConvertible
        {
        /// <summary>
        /// 
        /// </summary>
        private const double POINT_EPSILON = (1e-4);

        public static readonly Point3F One = new Point3F(1.0f, 1.0f, 1.0f);
        public static readonly Point3F Zero = new Point3F(0.0f, 0.0f, 0.0f);
        public static readonly Point3F Min = new Point3F(float.MinValue, float.MinValue, float.MinValue);
        public static readonly Point3F Max = new Point3F(float.MaxValue, float.MaxValue, float.MaxValue);
        public static readonly Point3F UnitX = new Point3F(1.0f, .0f, .0f);
        public static readonly Point3F UnitY = new Point3F(.0f, 1.0f, .0f);
        public static readonly Point3F UnitZ = new Point3F(.0f, .0f, 1.0f);


        private float _x;
        private float _y;
        private float _z;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transform"></param>
        public Point3F(string transform)
            {
            string[] parts = transform.Split(' ');
            if (parts.GetUpperBound(0) >= 2)
                {
                x = parts[0].AsFloat();
                y = parts[1].AsFloat();
                z = parts[2].AsFloat();
                }
            else
                {
                Console.WriteLine(Resources.Point3F_Point3F_Point3F___Error_Invalid_Transform_ + transform);
                x = 0;
                y = 0;
                z = 0;
                }
            }

        /// <summary>
        /// 
        /// </summary>
        public Point3F()
            {
            x = 0;
            y = 0;
            z = 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Empty"></param>
        public Point3F(bool Empty)
            {
            x = 0;
            y = 0;
            z = 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public Point3F(Point3F p)
            {
            x = p.x;
            y = p.y;
            z = p.z;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xyz"></param>
        public Point3F(float xyz)
            {
            x = xyz;
            y = xyz;
            z = xyz;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="in_x"></param>
        /// <param name="in_y"></param>
        /// <param name="in_z"></param>
        public Point3F(float in_x, float in_y, float in_z)
            {
            x = in_x;
            y = in_y;
            z = in_z;
            }

        /// <summary>
        /// 
        /// </summary>
        public float x
            {
            get { return _x; }
            set
                {
                _x = value;
                //   Notify(AsString());
                }
            }

        /// <summary>
        /// 
        /// </summary>
        public float y
            {
            get { return _y; }
            set
                {
                _y = value;
                //     Notify(AsString());
                }
            }

        /// <summary>
        /// 
        /// </summary>
        public float z
            {
            get { return _z; }
            set
                {
                _z = value;
                //     Notify(AsString());
                }
            }

        #region IConvertible Members

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public TypeCode GetTypeCode()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public bool ToBoolean(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public byte ToByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public char ToChar(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public DateTime ToDateTime(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public decimal ToDecimal(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public double ToDouble(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public short ToInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public int ToInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public long ToInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public sbyte ToSByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public float ToSingle(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
            {
            return this.AsString();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public ushort ToUInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public uint ToUInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public ulong ToUInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        ~Point3F()
            {
            //    this.DetachAllEvents();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} ", x.AsString(), y.AsString(), z.AsString());
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
            {
            return string.Format("{0} {1} {2} ", x.AsString(), y.AsString(), z.AsString());
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_test"></param>
        public void SetMin(Point3F _test)
            {
            x = (_test.x < x) ? _test.x : x;
            y = (_test.y < y) ? _test.y : y;
            z = (_test.z < z) ? _test.z : z;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_test"></param>
        public void SetMax(Point3F _test)
            {
            x = (_test.x > x) ? _test.x : x;
            y = (_test.y > y) ? _test.y : y;
            z = (_test.z > z) ? _test.z : z;
            }

        /// <summary>
        /// 
        /// </summary>
        public void neg()
            {
            x = -x;
            y = -y;
            z = -z;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_testo"></param>
        /// <returns></returns>
        public override bool Equals(object _testo)
            {
            Point3F _test = (Point3F)_testo;
            return (x == _test.x) && (y == _test.y) && (z == _test.z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator ==(Point3F x, Point3F _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return true;

            if (((object) _test) == null)
                return false;

            if (((object)x) == null)
                return false;

            return (x.x == _test.x) && (x.y == _test.y) && (x.z == _test.z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_test"></param>
        /// <returns></returns>
        public static bool operator !=(Point3F x, Point3F _test)
            {
            if (((object)_test) == null && ((object)x == null))
                return false;

            if (((object)_test) == null)
                return true;

            if (((object)x) == null)
                return true;

            return x == (_test) == false;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_add"></param>
        /// <returns></returns>
        public static Point3F operator +(Point3F x, Point3F _add)
            {
            return new Point3F(x.x + _add.x, x.y + _add.y, x.z + _add.z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_rSub"></param>
        /// <returns></returns>
        public static Point3F operator -(Point3F x, Point3F _rSub)
            {
            return new Point3F(x.x - _rSub.x, x.y - _rSub.y, x.z - _rSub.z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_mul"></param>
        /// <returns></returns>
        public static Point3F operator *(Point3F x, float _mul)
            {
            return new Point3F(x.x * _mul, x.y * _mul, x.z * _mul);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="_div"></param>
        /// <returns></returns>
        public static Point3F operator /(Point3F x, float _div)
            {
            if (_div == 0.0)
                throw new Exception("Error, Divide by Zero");
            float inv = 1.0f / _div;
            return new Point3F(x.x * inv, x.y * inv, x.z * inv);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Point3F operator -(Point3F x)
            {
            return new Point3F(-x.x, -x.y, -x.z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double getMin(double a, double b)
            {
            return a > b ? b : a;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double getMax(double a, double b)
            {
            return a > b ? a : b;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double mDegToRad(double d)
            {
            return ((d * Math.PI) / 180.0);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static double mRadToDeg(double r)
            {
            return ((r * 180.0) / Math.PI);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static Point3F vectorScale(Point3F point, float scalar)
            {
            return point * scalar;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static float vectorDot(Point3F p1, Point3F p2)
            {
            return (p1.x * p2.x + p1.y * p2.y + p1.z * p2.z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public Point3F vecotrScale(float scalar)
            {
            return this * scalar;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="velocity"></param>
        /// <returns></returns>
        public float vectorDot(Point3F velocity)
            {
            return Point3F.vectorDot(this, velocity);
            }

        /// <summary>
        /// 
        /// </summary>
        public void zero()
            {
            x = y = z = 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isZero()
            {
            return ((x * x) <= POINT_EPSILON) && ((y * y) <= POINT_EPSILON) && ((z * z) <= POINT_EPSILON);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isUnitLength()
            {
            return (Math.Abs(1.0f - (x * x + y * y + z * z)) < POINT_EPSILON);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="compare"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public bool equal(Point3F compare, double epsilon)
            {
            return ((Math.Abs(x - compare.x) < epsilon) && (Math.Abs(y - compare.y) < epsilon) &&
                    (Math.Abs(z - compare.z) < epsilon));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UInt32 getLeastcomponentIndex()
            {
            UInt32 idx;

            if (Math.Abs(x) < Math.Abs(y))
                {
                if (Math.Abs(x) < Math.Abs(z))
                    idx = 0;
                else
                    idx = 2;
                }
            else
                {
                if (Math.Abs(y) < Math.Abs(z))
                    idx = 1;
                else
                    idx = 2;
                }

            return idx;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UInt32 getGreatestComponentIndex()
            {
            UInt32 idx;

            if (Math.Abs(x) > Math.Abs(y))
                {
                if (Math.Abs(x) > Math.Abs(z))
                    idx = 0;
                else
                    idx = 2;
                }
            else
                {
                if (Math.Abs(y) > Math.Abs(z))
                    idx = 1;
                else
                    idx = 2;
                }

            return idx;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double least()
            {
            return getMin(Math.Abs(x), getMin(Math.Abs(y), Math.Abs(z)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double most()
            {
            return getMax(Math.Abs(x), getMax(Math.Abs(y), Math.Abs(z)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public void convolve(Point3F c)
            {
            x *= c.x;
            y *= c.y;
            z *= c.z;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public void convolveInverse(Point3F c)
            {
            x /= c.x;
            y /= c.y;
            z /= c.z;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double lenSquared()
            {
            return (x * x) + (y * y) + (z * z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double len()
            {
            return Math.Sqrt(x * x + y * y + z * z);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Point3F normalizeSafe()
            {
            double vmag = magnitudeSafe();

            if (vmag > POINT_EPSILON)
                {
                x *= (float)(1.0 / vmag);
                y *= (float)(1.0 / vmag);
                z *= (float)(1.0 / vmag);
                }
            return this;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double magnitudeSafe()
            {
            if (isZero())
                {
                return 0.0f;
                }
            else
                {
                return len();
                }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Point3F copy()
            {
            Point3F t = new Point3F(x, y, z); //, axis_x, axis_y, axis_z, angle);
            return t;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public Point3F vectorScale(float scalar)
            {
            return this * scalar;
            }
        }

    public static partial class Extension
        {
        /// <summary>
        /// Returns string as Point3F
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Point3F AsPoint3F(this string value)
            {
            return new Point3F(value);
            }
        }
    }