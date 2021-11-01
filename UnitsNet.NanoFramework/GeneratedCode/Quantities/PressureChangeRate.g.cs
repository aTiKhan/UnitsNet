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
    ///     Pressure change rate is the ratio of the pressure change to the time during which the change occurred (value of pressure changes per unit time).
    /// </summary>
    public struct  PressureChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly PressureChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public PressureChangeRateUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public PressureChangeRate(double value, PressureChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static PressureChangeRateUnit ConversionBaseUnit { get; } = PressureChangeRateUnit.PascalPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static PressureChangeRate MaxValue { get; } = new PressureChangeRate(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static PressureChangeRate MinValue { get; } = new PressureChangeRate(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static PressureChangeRate Zero { get; } = new PressureChangeRate(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get PressureChangeRate in AtmospheresPerSecond.
        /// </summary>
        public double AtmospheresPerSecond => As(PressureChangeRateUnit.AtmospherePerSecond);

        /// <summary>
        ///     Get PressureChangeRate in KilopascalsPerMinute.
        /// </summary>
        public double KilopascalsPerMinute => As(PressureChangeRateUnit.KilopascalPerMinute);

        /// <summary>
        ///     Get PressureChangeRate in KilopascalsPerSecond.
        /// </summary>
        public double KilopascalsPerSecond => As(PressureChangeRateUnit.KilopascalPerSecond);

        /// <summary>
        ///     Get PressureChangeRate in KilopoundsForcePerSquareInchPerMinute.
        /// </summary>
        public double KilopoundsForcePerSquareInchPerMinute => As(PressureChangeRateUnit.KilopoundForcePerSquareInchPerMinute);

        /// <summary>
        ///     Get PressureChangeRate in KilopoundsForcePerSquareInchPerSecond.
        /// </summary>
        public double KilopoundsForcePerSquareInchPerSecond => As(PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);

        /// <summary>
        ///     Get PressureChangeRate in MegapascalsPerMinute.
        /// </summary>
        public double MegapascalsPerMinute => As(PressureChangeRateUnit.MegapascalPerMinute);

        /// <summary>
        ///     Get PressureChangeRate in MegapascalsPerSecond.
        /// </summary>
        public double MegapascalsPerSecond => As(PressureChangeRateUnit.MegapascalPerSecond);

        /// <summary>
        ///     Get PressureChangeRate in MegapoundsForcePerSquareInchPerMinute.
        /// </summary>
        public double MegapoundsForcePerSquareInchPerMinute => As(PressureChangeRateUnit.MegapoundForcePerSquareInchPerMinute);

        /// <summary>
        ///     Get PressureChangeRate in MegapoundsForcePerSquareInchPerSecond.
        /// </summary>
        public double MegapoundsForcePerSquareInchPerSecond => As(PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);

        /// <summary>
        ///     Get PressureChangeRate in PascalsPerMinute.
        /// </summary>
        public double PascalsPerMinute => As(PressureChangeRateUnit.PascalPerMinute);

        /// <summary>
        ///     Get PressureChangeRate in PascalsPerSecond.
        /// </summary>
        public double PascalsPerSecond => As(PressureChangeRateUnit.PascalPerSecond);

        /// <summary>
        ///     Get PressureChangeRate in PoundsForcePerSquareInchPerMinute.
        /// </summary>
        public double PoundsForcePerSquareInchPerMinute => As(PressureChangeRateUnit.PoundForcePerSquareInchPerMinute);

        /// <summary>
        ///     Get PressureChangeRate in PoundsForcePerSquareInchPerSecond.
        /// </summary>
        public double PoundsForcePerSquareInchPerSecond => As(PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get PressureChangeRate from AtmospheresPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromAtmospheresPerSecond(double atmospherespersecond) => new PressureChangeRate(atmospherespersecond, PressureChangeRateUnit.AtmospherePerSecond);

        /// <summary>
        ///     Get PressureChangeRate from KilopascalsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopascalsPerMinute(double kilopascalsperminute) => new PressureChangeRate(kilopascalsperminute, PressureChangeRateUnit.KilopascalPerMinute);

        /// <summary>
        ///     Get PressureChangeRate from KilopascalsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopascalsPerSecond(double kilopascalspersecond) => new PressureChangeRate(kilopascalspersecond, PressureChangeRateUnit.KilopascalPerSecond);

        /// <summary>
        ///     Get PressureChangeRate from KilopoundsForcePerSquareInchPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopoundsForcePerSquareInchPerMinute(double kilopoundsforcepersquareinchperminute) => new PressureChangeRate(kilopoundsforcepersquareinchperminute, PressureChangeRateUnit.KilopoundForcePerSquareInchPerMinute);

        /// <summary>
        ///     Get PressureChangeRate from KilopoundsForcePerSquareInchPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromKilopoundsForcePerSquareInchPerSecond(double kilopoundsforcepersquareinchpersecond) => new PressureChangeRate(kilopoundsforcepersquareinchpersecond, PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);

        /// <summary>
        ///     Get PressureChangeRate from MegapascalsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapascalsPerMinute(double megapascalsperminute) => new PressureChangeRate(megapascalsperminute, PressureChangeRateUnit.MegapascalPerMinute);

        /// <summary>
        ///     Get PressureChangeRate from MegapascalsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapascalsPerSecond(double megapascalspersecond) => new PressureChangeRate(megapascalspersecond, PressureChangeRateUnit.MegapascalPerSecond);

        /// <summary>
        ///     Get PressureChangeRate from MegapoundsForcePerSquareInchPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapoundsForcePerSquareInchPerMinute(double megapoundsforcepersquareinchperminute) => new PressureChangeRate(megapoundsforcepersquareinchperminute, PressureChangeRateUnit.MegapoundForcePerSquareInchPerMinute);

        /// <summary>
        ///     Get PressureChangeRate from MegapoundsForcePerSquareInchPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromMegapoundsForcePerSquareInchPerSecond(double megapoundsforcepersquareinchpersecond) => new PressureChangeRate(megapoundsforcepersquareinchpersecond, PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);

        /// <summary>
        ///     Get PressureChangeRate from PascalsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPascalsPerMinute(double pascalsperminute) => new PressureChangeRate(pascalsperminute, PressureChangeRateUnit.PascalPerMinute);

        /// <summary>
        ///     Get PressureChangeRate from PascalsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPascalsPerSecond(double pascalspersecond) => new PressureChangeRate(pascalspersecond, PressureChangeRateUnit.PascalPerSecond);

        /// <summary>
        ///     Get PressureChangeRate from PoundsForcePerSquareInchPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPoundsForcePerSquareInchPerMinute(double poundsforcepersquareinchperminute) => new PressureChangeRate(poundsforcepersquareinchperminute, PressureChangeRateUnit.PoundForcePerSquareInchPerMinute);

        /// <summary>
        ///     Get PressureChangeRate from PoundsForcePerSquareInchPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PressureChangeRate FromPoundsForcePerSquareInchPerSecond(double poundsforcepersquareinchpersecond) => new PressureChangeRate(poundsforcepersquareinchpersecond, PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PressureChangeRateUnit" /> to <see cref="PressureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PressureChangeRate unit value.</returns>
        public static PressureChangeRate From(double value, PressureChangeRateUnit fromUnit)
        {
            return new PressureChangeRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(PressureChangeRateUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public PressureChangeRate ToUnit(PressureChangeRateUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new PressureChangeRate(convertedValue, unit);
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
                case PressureChangeRateUnit.AtmospherePerSecond: return _value * 1.01325*1e5;
                case PressureChangeRateUnit.KilopascalPerMinute: return (_value/60) * 1e3d;
                case PressureChangeRateUnit.KilopascalPerSecond: return (_value) * 1e3d;
                case PressureChangeRateUnit.KilopoundForcePerSquareInchPerMinute: return (_value*6.894757293168361e3/60) * 1e3d;
                case PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond: return (_value*6.894757293168361e3) * 1e3d;
                case PressureChangeRateUnit.MegapascalPerMinute: return (_value/60) * 1e6d;
                case PressureChangeRateUnit.MegapascalPerSecond: return (_value) * 1e6d;
                case PressureChangeRateUnit.MegapoundForcePerSquareInchPerMinute: return (_value*6.894757293168361e3/60) * 1e6d;
                case PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond: return (_value*6.894757293168361e3) * 1e6d;
                case PressureChangeRateUnit.PascalPerMinute: return _value/60;
                case PressureChangeRateUnit.PascalPerSecond: return _value;
                case PressureChangeRateUnit.PoundForcePerSquareInchPerMinute: return _value*6.894757293168361e3/60;
                case PressureChangeRateUnit.PoundForcePerSquareInchPerSecond: return _value*6.894757293168361e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(PressureChangeRateUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case PressureChangeRateUnit.AtmospherePerSecond: return baseUnitValue / (1.01325*1e5);
                case PressureChangeRateUnit.KilopascalPerMinute: return (baseUnitValue*60) / 1e3d;
                case PressureChangeRateUnit.KilopascalPerSecond: return (baseUnitValue) / 1e3d;
                case PressureChangeRateUnit.KilopoundForcePerSquareInchPerMinute: return (baseUnitValue/6.894757293168361e3*60) / 1e3d;
                case PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond: return (baseUnitValue/6.894757293168361e3) / 1e3d;
                case PressureChangeRateUnit.MegapascalPerMinute: return (baseUnitValue*60) / 1e6d;
                case PressureChangeRateUnit.MegapascalPerSecond: return (baseUnitValue) / 1e6d;
                case PressureChangeRateUnit.MegapoundForcePerSquareInchPerMinute: return (baseUnitValue/6.894757293168361e3*60) / 1e6d;
                case PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond: return (baseUnitValue/6.894757293168361e3) / 1e6d;
                case PressureChangeRateUnit.PascalPerMinute: return baseUnitValue*60;
                case PressureChangeRateUnit.PascalPerSecond: return baseUnitValue;
                case PressureChangeRateUnit.PoundForcePerSquareInchPerMinute: return baseUnitValue/6.894757293168361e3*60;
                case PressureChangeRateUnit.PoundForcePerSquareInchPerSecond: return baseUnitValue/6.894757293168361e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

