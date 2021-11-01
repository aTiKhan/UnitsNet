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
    ///     Heat flux is the flow of energy per unit of area per unit of time
    /// </summary>
    public struct  HeatFlux
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly HeatFluxUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public HeatFluxUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public HeatFlux(double value, HeatFluxUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static HeatFluxUnit ConversionBaseUnit { get; } = HeatFluxUnit.WattPerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static HeatFlux MaxValue { get; } = new HeatFlux(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static HeatFlux MinValue { get; } = new HeatFlux(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static HeatFlux Zero { get; } = new HeatFlux(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get HeatFlux in BtusPerHourSquareFoot.
        /// </summary>
        public double BtusPerHourSquareFoot => As(HeatFluxUnit.BtuPerHourSquareFoot);

        /// <summary>
        ///     Get HeatFlux in BtusPerMinuteSquareFoot.
        /// </summary>
        public double BtusPerMinuteSquareFoot => As(HeatFluxUnit.BtuPerMinuteSquareFoot);

        /// <summary>
        ///     Get HeatFlux in BtusPerSecondSquareFoot.
        /// </summary>
        public double BtusPerSecondSquareFoot => As(HeatFluxUnit.BtuPerSecondSquareFoot);

        /// <summary>
        ///     Get HeatFlux in BtusPerSecondSquareInch.
        /// </summary>
        public double BtusPerSecondSquareInch => As(HeatFluxUnit.BtuPerSecondSquareInch);

        /// <summary>
        ///     Get HeatFlux in CaloriesPerSecondSquareCentimeter.
        /// </summary>
        public double CaloriesPerSecondSquareCentimeter => As(HeatFluxUnit.CaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Get HeatFlux in CentiwattsPerSquareMeter.
        /// </summary>
        public double CentiwattsPerSquareMeter => As(HeatFluxUnit.CentiwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in DeciwattsPerSquareMeter.
        /// </summary>
        public double DeciwattsPerSquareMeter => As(HeatFluxUnit.DeciwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in KilocaloriesPerHourSquareMeter.
        /// </summary>
        public double KilocaloriesPerHourSquareMeter => As(HeatFluxUnit.KilocaloriePerHourSquareMeter);

        /// <summary>
        ///     Get HeatFlux in KilocaloriesPerSecondSquareCentimeter.
        /// </summary>
        public double KilocaloriesPerSecondSquareCentimeter => As(HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Get HeatFlux in KilowattsPerSquareMeter.
        /// </summary>
        public double KilowattsPerSquareMeter => As(HeatFluxUnit.KilowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in MicrowattsPerSquareMeter.
        /// </summary>
        public double MicrowattsPerSquareMeter => As(HeatFluxUnit.MicrowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in MilliwattsPerSquareMeter.
        /// </summary>
        public double MilliwattsPerSquareMeter => As(HeatFluxUnit.MilliwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in NanowattsPerSquareMeter.
        /// </summary>
        public double NanowattsPerSquareMeter => As(HeatFluxUnit.NanowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in PoundsForcePerFootSecond.
        /// </summary>
        public double PoundsForcePerFootSecond => As(HeatFluxUnit.PoundForcePerFootSecond);

        /// <summary>
        ///     Get HeatFlux in PoundsPerSecondCubed.
        /// </summary>
        public double PoundsPerSecondCubed => As(HeatFluxUnit.PoundPerSecondCubed);

        /// <summary>
        ///     Get HeatFlux in WattsPerSquareFoot.
        /// </summary>
        public double WattsPerSquareFoot => As(HeatFluxUnit.WattPerSquareFoot);

        /// <summary>
        ///     Get HeatFlux in WattsPerSquareInch.
        /// </summary>
        public double WattsPerSquareInch => As(HeatFluxUnit.WattPerSquareInch);

        /// <summary>
        ///     Get HeatFlux in WattsPerSquareMeter.
        /// </summary>
        public double WattsPerSquareMeter => As(HeatFluxUnit.WattPerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get HeatFlux from BtusPerHourSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerHourSquareFoot(double btusperhoursquarefoot) => new HeatFlux(btusperhoursquarefoot, HeatFluxUnit.BtuPerHourSquareFoot);

        /// <summary>
        ///     Get HeatFlux from BtusPerMinuteSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerMinuteSquareFoot(double btusperminutesquarefoot) => new HeatFlux(btusperminutesquarefoot, HeatFluxUnit.BtuPerMinuteSquareFoot);

        /// <summary>
        ///     Get HeatFlux from BtusPerSecondSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerSecondSquareFoot(double btuspersecondsquarefoot) => new HeatFlux(btuspersecondsquarefoot, HeatFluxUnit.BtuPerSecondSquareFoot);

        /// <summary>
        ///     Get HeatFlux from BtusPerSecondSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerSecondSquareInch(double btuspersecondsquareinch) => new HeatFlux(btuspersecondsquareinch, HeatFluxUnit.BtuPerSecondSquareInch);

        /// <summary>
        ///     Get HeatFlux from CaloriesPerSecondSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromCaloriesPerSecondSquareCentimeter(double caloriespersecondsquarecentimeter) => new HeatFlux(caloriespersecondsquarecentimeter, HeatFluxUnit.CaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Get HeatFlux from CentiwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromCentiwattsPerSquareMeter(double centiwattspersquaremeter) => new HeatFlux(centiwattspersquaremeter, HeatFluxUnit.CentiwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux from DeciwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromDeciwattsPerSquareMeter(double deciwattspersquaremeter) => new HeatFlux(deciwattspersquaremeter, HeatFluxUnit.DeciwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux from KilocaloriesPerHourSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilocaloriesPerHourSquareMeter(double kilocaloriesperhoursquaremeter) => new HeatFlux(kilocaloriesperhoursquaremeter, HeatFluxUnit.KilocaloriePerHourSquareMeter);

        /// <summary>
        ///     Get HeatFlux from KilocaloriesPerSecondSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilocaloriesPerSecondSquareCentimeter(double kilocaloriespersecondsquarecentimeter) => new HeatFlux(kilocaloriespersecondsquarecentimeter, HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Get HeatFlux from KilowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilowattsPerSquareMeter(double kilowattspersquaremeter) => new HeatFlux(kilowattspersquaremeter, HeatFluxUnit.KilowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux from MicrowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromMicrowattsPerSquareMeter(double microwattspersquaremeter) => new HeatFlux(microwattspersquaremeter, HeatFluxUnit.MicrowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux from MilliwattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromMilliwattsPerSquareMeter(double milliwattspersquaremeter) => new HeatFlux(milliwattspersquaremeter, HeatFluxUnit.MilliwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux from NanowattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromNanowattsPerSquareMeter(double nanowattspersquaremeter) => new HeatFlux(nanowattspersquaremeter, HeatFluxUnit.NanowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux from PoundsForcePerFootSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromPoundsForcePerFootSecond(double poundsforceperfootsecond) => new HeatFlux(poundsforceperfootsecond, HeatFluxUnit.PoundForcePerFootSecond);

        /// <summary>
        ///     Get HeatFlux from PoundsPerSecondCubed.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromPoundsPerSecondCubed(double poundspersecondcubed) => new HeatFlux(poundspersecondcubed, HeatFluxUnit.PoundPerSecondCubed);

        /// <summary>
        ///     Get HeatFlux from WattsPerSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareFoot(double wattspersquarefoot) => new HeatFlux(wattspersquarefoot, HeatFluxUnit.WattPerSquareFoot);

        /// <summary>
        ///     Get HeatFlux from WattsPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareInch(double wattspersquareinch) => new HeatFlux(wattspersquareinch, HeatFluxUnit.WattPerSquareInch);

        /// <summary>
        ///     Get HeatFlux from WattsPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareMeter(double wattspersquaremeter) => new HeatFlux(wattspersquaremeter, HeatFluxUnit.WattPerSquareMeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="HeatFluxUnit" /> to <see cref="HeatFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>HeatFlux unit value.</returns>
        public static HeatFlux From(double value, HeatFluxUnit fromUnit)
        {
            return new HeatFlux(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(HeatFluxUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public HeatFlux ToUnit(HeatFluxUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new HeatFlux(convertedValue, unit);
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
                case HeatFluxUnit.BtuPerHourSquareFoot: return _value*3.15459075;
                case HeatFluxUnit.BtuPerMinuteSquareFoot: return _value*1.89275445e2;
                case HeatFluxUnit.BtuPerSecondSquareFoot: return _value*1.13565267e4;
                case HeatFluxUnit.BtuPerSecondSquareInch: return _value*1.63533984e6;
                case HeatFluxUnit.CaloriePerSecondSquareCentimeter: return _value*4.1868e4;
                case HeatFluxUnit.CentiwattPerSquareMeter: return (_value) * 1e-2d;
                case HeatFluxUnit.DeciwattPerSquareMeter: return (_value) * 1e-1d;
                case HeatFluxUnit.KilocaloriePerHourSquareMeter: return _value*1.163;
                case HeatFluxUnit.KilocaloriePerSecondSquareCentimeter: return (_value*4.1868e4) * 1e3d;
                case HeatFluxUnit.KilowattPerSquareMeter: return (_value) * 1e3d;
                case HeatFluxUnit.MicrowattPerSquareMeter: return (_value) * 1e-6d;
                case HeatFluxUnit.MilliwattPerSquareMeter: return (_value) * 1e-3d;
                case HeatFluxUnit.NanowattPerSquareMeter: return (_value) * 1e-9d;
                case HeatFluxUnit.PoundForcePerFootSecond: return _value*1.459390293720636e1;
                case HeatFluxUnit.PoundPerSecondCubed: return _value*4.5359237e-1;
                case HeatFluxUnit.WattPerSquareFoot: return _value*1.07639e1;
                case HeatFluxUnit.WattPerSquareInch: return _value*1.5500031e3;
                case HeatFluxUnit.WattPerSquareMeter: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(HeatFluxUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case HeatFluxUnit.BtuPerHourSquareFoot: return baseUnitValue/3.15459075;
                case HeatFluxUnit.BtuPerMinuteSquareFoot: return baseUnitValue/1.89275445e2;
                case HeatFluxUnit.BtuPerSecondSquareFoot: return baseUnitValue/1.13565267e4;
                case HeatFluxUnit.BtuPerSecondSquareInch: return baseUnitValue/1.63533984e6;
                case HeatFluxUnit.CaloriePerSecondSquareCentimeter: return baseUnitValue/4.1868e4;
                case HeatFluxUnit.CentiwattPerSquareMeter: return (baseUnitValue) / 1e-2d;
                case HeatFluxUnit.DeciwattPerSquareMeter: return (baseUnitValue) / 1e-1d;
                case HeatFluxUnit.KilocaloriePerHourSquareMeter: return baseUnitValue/1.163;
                case HeatFluxUnit.KilocaloriePerSecondSquareCentimeter: return (baseUnitValue/4.1868e4) / 1e3d;
                case HeatFluxUnit.KilowattPerSquareMeter: return (baseUnitValue) / 1e3d;
                case HeatFluxUnit.MicrowattPerSquareMeter: return (baseUnitValue) / 1e-6d;
                case HeatFluxUnit.MilliwattPerSquareMeter: return (baseUnitValue) / 1e-3d;
                case HeatFluxUnit.NanowattPerSquareMeter: return (baseUnitValue) / 1e-9d;
                case HeatFluxUnit.PoundForcePerFootSecond: return baseUnitValue/1.459390293720636e1;
                case HeatFluxUnit.PoundPerSecondCubed: return baseUnitValue/4.5359237e-1;
                case HeatFluxUnit.WattPerSquareFoot: return baseUnitValue/1.07639e1;
                case HeatFluxUnit.WattPerSquareInch: return baseUnitValue/1.5500031e3;
                case HeatFluxUnit.WattPerSquareMeter: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

