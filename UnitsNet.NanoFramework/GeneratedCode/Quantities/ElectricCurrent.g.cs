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
    ///     An electric current is a flow of electric charge. In electric circuits this charge is often carried by moving electrons in a wire. It can also be carried by ions in an electrolyte, or by both ions and electrons such as in a plasma.
    /// </summary>
    public struct  ElectricCurrent
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricCurrentUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricCurrentUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricCurrent(double value, ElectricCurrentUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricCurrentUnit ConversionBaseUnit { get; } = ElectricCurrentUnit.Ampere;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricCurrent MaxValue { get; } = new ElectricCurrent(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricCurrent MinValue { get; } = new ElectricCurrent(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricCurrent Zero { get; } = new ElectricCurrent(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ElectricCurrent in Amperes.
        /// </summary>
        public double Amperes => As(ElectricCurrentUnit.Ampere);

        /// <summary>
        ///     Get ElectricCurrent in Centiamperes.
        /// </summary>
        public double Centiamperes => As(ElectricCurrentUnit.Centiampere);

        /// <summary>
        ///     Get ElectricCurrent in Kiloamperes.
        /// </summary>
        public double Kiloamperes => As(ElectricCurrentUnit.Kiloampere);

        /// <summary>
        ///     Get ElectricCurrent in Megaamperes.
        /// </summary>
        public double Megaamperes => As(ElectricCurrentUnit.Megaampere);

        /// <summary>
        ///     Get ElectricCurrent in Microamperes.
        /// </summary>
        public double Microamperes => As(ElectricCurrentUnit.Microampere);

        /// <summary>
        ///     Get ElectricCurrent in Milliamperes.
        /// </summary>
        public double Milliamperes => As(ElectricCurrentUnit.Milliampere);

        /// <summary>
        ///     Get ElectricCurrent in Nanoamperes.
        /// </summary>
        public double Nanoamperes => As(ElectricCurrentUnit.Nanoampere);

        /// <summary>
        ///     Get ElectricCurrent in Picoamperes.
        /// </summary>
        public double Picoamperes => As(ElectricCurrentUnit.Picoampere);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ElectricCurrent from Amperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromAmperes(double amperes) => new ElectricCurrent(amperes, ElectricCurrentUnit.Ampere);

        /// <summary>
        ///     Get ElectricCurrent from Centiamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromCentiamperes(double centiamperes) => new ElectricCurrent(centiamperes, ElectricCurrentUnit.Centiampere);

        /// <summary>
        ///     Get ElectricCurrent from Kiloamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromKiloamperes(double kiloamperes) => new ElectricCurrent(kiloamperes, ElectricCurrentUnit.Kiloampere);

        /// <summary>
        ///     Get ElectricCurrent from Megaamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromMegaamperes(double megaamperes) => new ElectricCurrent(megaamperes, ElectricCurrentUnit.Megaampere);

        /// <summary>
        ///     Get ElectricCurrent from Microamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromMicroamperes(double microamperes) => new ElectricCurrent(microamperes, ElectricCurrentUnit.Microampere);

        /// <summary>
        ///     Get ElectricCurrent from Milliamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromMilliamperes(double milliamperes) => new ElectricCurrent(milliamperes, ElectricCurrentUnit.Milliampere);

        /// <summary>
        ///     Get ElectricCurrent from Nanoamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromNanoamperes(double nanoamperes) => new ElectricCurrent(nanoamperes, ElectricCurrentUnit.Nanoampere);

        /// <summary>
        ///     Get ElectricCurrent from Picoamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromPicoamperes(double picoamperes) => new ElectricCurrent(picoamperes, ElectricCurrentUnit.Picoampere);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricCurrentUnit" /> to <see cref="ElectricCurrent" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCurrent unit value.</returns>
        public static ElectricCurrent From(double value, ElectricCurrentUnit fromUnit)
        {
            return new ElectricCurrent(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricCurrentUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricCurrent ToUnit(ElectricCurrentUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricCurrent(convertedValue, unit);
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
                case ElectricCurrentUnit.Ampere: return _value;
                case ElectricCurrentUnit.Centiampere: return (_value) * 1e-2d;
                case ElectricCurrentUnit.Kiloampere: return (_value) * 1e3d;
                case ElectricCurrentUnit.Megaampere: return (_value) * 1e6d;
                case ElectricCurrentUnit.Microampere: return (_value) * 1e-6d;
                case ElectricCurrentUnit.Milliampere: return (_value) * 1e-3d;
                case ElectricCurrentUnit.Nanoampere: return (_value) * 1e-9d;
                case ElectricCurrentUnit.Picoampere: return (_value) * 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ElectricCurrentUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ElectricCurrentUnit.Ampere: return baseUnitValue;
                case ElectricCurrentUnit.Centiampere: return (baseUnitValue) / 1e-2d;
                case ElectricCurrentUnit.Kiloampere: return (baseUnitValue) / 1e3d;
                case ElectricCurrentUnit.Megaampere: return (baseUnitValue) / 1e6d;
                case ElectricCurrentUnit.Microampere: return (baseUnitValue) / 1e-6d;
                case ElectricCurrentUnit.Milliampere: return (baseUnitValue) / 1e-3d;
                case ElectricCurrentUnit.Nanoampere: return (baseUnitValue) / 1e-9d;
                case ElectricCurrentUnit.Picoampere: return (baseUnitValue) / 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

