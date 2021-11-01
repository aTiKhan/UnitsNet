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
    ///     The volumetric heat capacity is the amount of energy that must be added, in the form of heat, to one unit of volume of the material in order to cause an increase of one unit in its temperature.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Volumetric_heat_capacity
    /// </remarks>
    public struct  VolumetricHeatCapacity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly VolumetricHeatCapacityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public VolumetricHeatCapacityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public VolumetricHeatCapacity(double value, VolumetricHeatCapacityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static VolumetricHeatCapacityUnit ConversionBaseUnit { get; } = VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static VolumetricHeatCapacity MaxValue { get; } = new VolumetricHeatCapacity(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static VolumetricHeatCapacity MinValue { get; } = new VolumetricHeatCapacity(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static VolumetricHeatCapacity Zero { get; } = new VolumetricHeatCapacity(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get VolumetricHeatCapacity in BtusPerCubicFootDegreeFahrenheit.
        /// </summary>
        public double BtusPerCubicFootDegreeFahrenheit => As(VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit);

        /// <summary>
        ///     Get VolumetricHeatCapacity in CaloriesPerCubicCentimeterDegreeCelsius.
        /// </summary>
        public double CaloriesPerCubicCentimeterDegreeCelsius => As(VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity in JoulesPerCubicMeterDegreeCelsius.
        /// </summary>
        public double JoulesPerCubicMeterDegreeCelsius => As(VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity in JoulesPerCubicMeterKelvin.
        /// </summary>
        public double JoulesPerCubicMeterKelvin => As(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);

        /// <summary>
        ///     Get VolumetricHeatCapacity in KilocaloriesPerCubicCentimeterDegreeCelsius.
        /// </summary>
        public double KilocaloriesPerCubicCentimeterDegreeCelsius => As(VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity in KilojoulesPerCubicMeterDegreeCelsius.
        /// </summary>
        public double KilojoulesPerCubicMeterDegreeCelsius => As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity in KilojoulesPerCubicMeterKelvin.
        /// </summary>
        public double KilojoulesPerCubicMeterKelvin => As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);

        /// <summary>
        ///     Get VolumetricHeatCapacity in MegajoulesPerCubicMeterDegreeCelsius.
        /// </summary>
        public double MegajoulesPerCubicMeterDegreeCelsius => As(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity in MegajoulesPerCubicMeterKelvin.
        /// </summary>
        public double MegajoulesPerCubicMeterKelvin => As(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get VolumetricHeatCapacity from BtusPerCubicFootDegreeFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromBtusPerCubicFootDegreeFahrenheit(double btuspercubicfootdegreefahrenheit) => new VolumetricHeatCapacity(btuspercubicfootdegreefahrenheit, VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit);

        /// <summary>
        ///     Get VolumetricHeatCapacity from CaloriesPerCubicCentimeterDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromCaloriesPerCubicCentimeterDegreeCelsius(double caloriespercubiccentimeterdegreecelsius) => new VolumetricHeatCapacity(caloriespercubiccentimeterdegreecelsius, VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity from JoulesPerCubicMeterDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromJoulesPerCubicMeterDegreeCelsius(double joulespercubicmeterdegreecelsius) => new VolumetricHeatCapacity(joulespercubicmeterdegreecelsius, VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity from JoulesPerCubicMeterKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromJoulesPerCubicMeterKelvin(double joulespercubicmeterkelvin) => new VolumetricHeatCapacity(joulespercubicmeterkelvin, VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);

        /// <summary>
        ///     Get VolumetricHeatCapacity from KilocaloriesPerCubicCentimeterDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromKilocaloriesPerCubicCentimeterDegreeCelsius(double kilocaloriespercubiccentimeterdegreecelsius) => new VolumetricHeatCapacity(kilocaloriespercubiccentimeterdegreecelsius, VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity from KilojoulesPerCubicMeterDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromKilojoulesPerCubicMeterDegreeCelsius(double kilojoulespercubicmeterdegreecelsius) => new VolumetricHeatCapacity(kilojoulespercubicmeterdegreecelsius, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity from KilojoulesPerCubicMeterKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromKilojoulesPerCubicMeterKelvin(double kilojoulespercubicmeterkelvin) => new VolumetricHeatCapacity(kilojoulespercubicmeterkelvin, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);

        /// <summary>
        ///     Get VolumetricHeatCapacity from MegajoulesPerCubicMeterDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromMegajoulesPerCubicMeterDegreeCelsius(double megajoulespercubicmeterdegreecelsius) => new VolumetricHeatCapacity(megajoulespercubicmeterdegreecelsius, VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Get VolumetricHeatCapacity from MegajoulesPerCubicMeterKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumetricHeatCapacity FromMegajoulesPerCubicMeterKelvin(double megajoulespercubicmeterkelvin) => new VolumetricHeatCapacity(megajoulespercubicmeterkelvin, VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumetricHeatCapacityUnit" /> to <see cref="VolumetricHeatCapacity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VolumetricHeatCapacity unit value.</returns>
        public static VolumetricHeatCapacity From(double value, VolumetricHeatCapacityUnit fromUnit)
        {
            return new VolumetricHeatCapacity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(VolumetricHeatCapacityUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public VolumetricHeatCapacity ToUnit(VolumetricHeatCapacityUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new VolumetricHeatCapacity(convertedValue, unit);
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
                case VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit: return _value / 1.4910660e-5;
                case VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius: return _value / 2.388459e-7;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius: return _value;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin: return _value;
                case VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius: return (_value / 2.388459e-7) * 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius: return (_value) * 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin: return (_value) * 1e3d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius: return (_value) * 1e6d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin: return (_value) * 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(VolumetricHeatCapacityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit: return baseUnitValue * 1.4910660e-5;
                case VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius: return baseUnitValue * 2.388459e-7;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius: return baseUnitValue;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin: return baseUnitValue;
                case VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius: return (baseUnitValue * 2.388459e-7) / 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius: return (baseUnitValue) / 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin: return (baseUnitValue) / 1e3d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius: return (baseUnitValue) / 1e6d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin: return (baseUnitValue) / 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

