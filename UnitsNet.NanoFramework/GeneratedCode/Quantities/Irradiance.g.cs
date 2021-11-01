//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Irradiance is the intensity of ultraviolet (UV) or visible light incident on a surface.
    /// </summary>
    public struct  Irradiance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly IrradianceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public IrradianceUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Irradiance(double value, IrradianceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static IrradianceUnit ConversionBaseUnit { get; } = IrradianceUnit.WattPerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Irradiance MaxValue { get; } = new Irradiance(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Irradiance MinValue { get; } = new Irradiance(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Irradiance Zero { get; } = new Irradiance(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Irradiance in KilowattsPerSquareCentimeter.
        /// </summary>
        public double KilowattsPerSquareCentimeter => As(IrradianceUnit.KilowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance in KilowattsPerSquareMeter.
        /// </summary>
        public double KilowattsPerSquareMeter => As(IrradianceUnit.KilowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance in MegawattsPerSquareCentimeter.
        /// </summary>
        public double MegawattsPerSquareCentimeter => As(IrradianceUnit.MegawattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance in MegawattsPerSquareMeter.
        /// </summary>
        public double MegawattsPerSquareMeter => As(IrradianceUnit.MegawattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance in MicrowattsPerSquareCentimeter.
        /// </summary>
        public double MicrowattsPerSquareCentimeter => As(IrradianceUnit.MicrowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance in MicrowattsPerSquareMeter.
        /// </summary>
        public double MicrowattsPerSquareMeter => As(IrradianceUnit.MicrowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance in MilliwattsPerSquareCentimeter.
        /// </summary>
        public double MilliwattsPerSquareCentimeter => As(IrradianceUnit.MilliwattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance in MilliwattsPerSquareMeter.
        /// </summary>
        public double MilliwattsPerSquareMeter => As(IrradianceUnit.MilliwattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance in NanowattsPerSquareCentimeter.
        /// </summary>
        public double NanowattsPerSquareCentimeter => As(IrradianceUnit.NanowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance in NanowattsPerSquareMeter.
        /// </summary>
        public double NanowattsPerSquareMeter => As(IrradianceUnit.NanowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance in PicowattsPerSquareCentimeter.
        /// </summary>
        public double PicowattsPerSquareCentimeter => As(IrradianceUnit.PicowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance in PicowattsPerSquareMeter.
        /// </summary>
        public double PicowattsPerSquareMeter => As(IrradianceUnit.PicowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance in WattsPerSquareCentimeter.
        /// </summary>
        public double WattsPerSquareCentimeter => As(IrradianceUnit.WattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance in WattsPerSquareMeter.
        /// </summary>
        public double WattsPerSquareMeter => As(IrradianceUnit.WattPerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Irradiance from KilowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromKilowattsPerSquareCentimeter(double kilowattspersquarecentimeter) => new Irradiance(kilowattspersquarecentimeter, IrradianceUnit.KilowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance from KilowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromKilowattsPerSquareMeter(double kilowattspersquaremeter) => new Irradiance(kilowattspersquaremeter, IrradianceUnit.KilowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance from MegawattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMegawattsPerSquareCentimeter(double megawattspersquarecentimeter) => new Irradiance(megawattspersquarecentimeter, IrradianceUnit.MegawattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance from MegawattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMegawattsPerSquareMeter(double megawattspersquaremeter) => new Irradiance(megawattspersquaremeter, IrradianceUnit.MegawattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance from MicrowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMicrowattsPerSquareCentimeter(double microwattspersquarecentimeter) => new Irradiance(microwattspersquarecentimeter, IrradianceUnit.MicrowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance from MicrowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMicrowattsPerSquareMeter(double microwattspersquaremeter) => new Irradiance(microwattspersquaremeter, IrradianceUnit.MicrowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance from MilliwattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMilliwattsPerSquareCentimeter(double milliwattspersquarecentimeter) => new Irradiance(milliwattspersquarecentimeter, IrradianceUnit.MilliwattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance from MilliwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromMilliwattsPerSquareMeter(double milliwattspersquaremeter) => new Irradiance(milliwattspersquaremeter, IrradianceUnit.MilliwattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance from NanowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromNanowattsPerSquareCentimeter(double nanowattspersquarecentimeter) => new Irradiance(nanowattspersquarecentimeter, IrradianceUnit.NanowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance from NanowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromNanowattsPerSquareMeter(double nanowattspersquaremeter) => new Irradiance(nanowattspersquaremeter, IrradianceUnit.NanowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance from PicowattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromPicowattsPerSquareCentimeter(double picowattspersquarecentimeter) => new Irradiance(picowattspersquarecentimeter, IrradianceUnit.PicowattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance from PicowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromPicowattsPerSquareMeter(double picowattspersquaremeter) => new Irradiance(picowattspersquaremeter, IrradianceUnit.PicowattPerSquareMeter);

        /// <summary>
        ///     Get Irradiance from WattsPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromWattsPerSquareCentimeter(double wattspersquarecentimeter) => new Irradiance(wattspersquarecentimeter, IrradianceUnit.WattPerSquareCentimeter);

        /// <summary>
        ///     Get Irradiance from WattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiance FromWattsPerSquareMeter(double wattspersquaremeter) => new Irradiance(wattspersquaremeter, IrradianceUnit.WattPerSquareMeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="IrradianceUnit" /> to <see cref="Irradiance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Irradiance unit value.</returns>
        public static Irradiance From(double value, IrradianceUnit fromUnit)
        {
            return new Irradiance(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(IrradianceUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Irradiance ToUnit(IrradianceUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Irradiance(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case IrradianceUnit.KilowattPerSquareCentimeter: return (_value*10000) * 1e3d;
                case IrradianceUnit.KilowattPerSquareMeter: return (_value) * 1e3d;
                case IrradianceUnit.MegawattPerSquareCentimeter: return (_value*10000) * 1e6d;
                case IrradianceUnit.MegawattPerSquareMeter: return (_value) * 1e6d;
                case IrradianceUnit.MicrowattPerSquareCentimeter: return (_value*10000) * 1e-6d;
                case IrradianceUnit.MicrowattPerSquareMeter: return (_value) * 1e-6d;
                case IrradianceUnit.MilliwattPerSquareCentimeter: return (_value*10000) * 1e-3d;
                case IrradianceUnit.MilliwattPerSquareMeter: return (_value) * 1e-3d;
                case IrradianceUnit.NanowattPerSquareCentimeter: return (_value*10000) * 1e-9d;
                case IrradianceUnit.NanowattPerSquareMeter: return (_value) * 1e-9d;
                case IrradianceUnit.PicowattPerSquareCentimeter: return (_value*10000) * 1e-12d;
                case IrradianceUnit.PicowattPerSquareMeter: return (_value) * 1e-12d;
                case IrradianceUnit.WattPerSquareCentimeter: return _value*10000;
                case IrradianceUnit.WattPerSquareMeter: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(IrradianceUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case IrradianceUnit.KilowattPerSquareCentimeter: return (baseUnitValue*0.0001) / 1e3d;
                case IrradianceUnit.KilowattPerSquareMeter: return (baseUnitValue) / 1e3d;
                case IrradianceUnit.MegawattPerSquareCentimeter: return (baseUnitValue*0.0001) / 1e6d;
                case IrradianceUnit.MegawattPerSquareMeter: return (baseUnitValue) / 1e6d;
                case IrradianceUnit.MicrowattPerSquareCentimeter: return (baseUnitValue*0.0001) / 1e-6d;
                case IrradianceUnit.MicrowattPerSquareMeter: return (baseUnitValue) / 1e-6d;
                case IrradianceUnit.MilliwattPerSquareCentimeter: return (baseUnitValue*0.0001) / 1e-3d;
                case IrradianceUnit.MilliwattPerSquareMeter: return (baseUnitValue) / 1e-3d;
                case IrradianceUnit.NanowattPerSquareCentimeter: return (baseUnitValue*0.0001) / 1e-9d;
                case IrradianceUnit.NanowattPerSquareMeter: return (baseUnitValue) / 1e-9d;
                case IrradianceUnit.PicowattPerSquareCentimeter: return (baseUnitValue*0.0001) / 1e-12d;
                case IrradianceUnit.PicowattPerSquareMeter: return (baseUnitValue) / 1e-12d;
                case IrradianceUnit.WattPerSquareCentimeter: return baseUnitValue*0.0001;
                case IrradianceUnit.WattPerSquareMeter: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

