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
    ///     Electric admittance is a measure of how easily a circuit or device will allow a current to flow. It is defined as the inverse of impedance. The SI unit of admittance is the siemens (symbol S).
    /// </summary>
    public struct  ElectricAdmittance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricAdmittanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricAdmittanceUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricAdmittance(double value, ElectricAdmittanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricAdmittanceUnit ConversionBaseUnit { get; } = ElectricAdmittanceUnit.Siemens;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricAdmittance MaxValue { get; } = new ElectricAdmittance(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricAdmittance MinValue { get; } = new ElectricAdmittance(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricAdmittance Zero { get; } = new ElectricAdmittance(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ElectricAdmittance in Microsiemens.
        /// </summary>
        public double Microsiemens => As(ElectricAdmittanceUnit.Microsiemens);

        /// <summary>
        ///     Get ElectricAdmittance in Millisiemens.
        /// </summary>
        public double Millisiemens => As(ElectricAdmittanceUnit.Millisiemens);

        /// <summary>
        ///     Get ElectricAdmittance in Nanosiemens.
        /// </summary>
        public double Nanosiemens => As(ElectricAdmittanceUnit.Nanosiemens);

        /// <summary>
        ///     Get ElectricAdmittance in Siemens.
        /// </summary>
        public double Siemens => As(ElectricAdmittanceUnit.Siemens);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ElectricAdmittance from Microsiemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromMicrosiemens(double microsiemens) => new ElectricAdmittance(microsiemens, ElectricAdmittanceUnit.Microsiemens);

        /// <summary>
        ///     Get ElectricAdmittance from Millisiemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromMillisiemens(double millisiemens) => new ElectricAdmittance(millisiemens, ElectricAdmittanceUnit.Millisiemens);

        /// <summary>
        ///     Get ElectricAdmittance from Nanosiemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromNanosiemens(double nanosiemens) => new ElectricAdmittance(nanosiemens, ElectricAdmittanceUnit.Nanosiemens);

        /// <summary>
        ///     Get ElectricAdmittance from Siemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromSiemens(double siemens) => new ElectricAdmittance(siemens, ElectricAdmittanceUnit.Siemens);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricAdmittanceUnit" /> to <see cref="ElectricAdmittance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricAdmittance unit value.</returns>
        public static ElectricAdmittance From(double value, ElectricAdmittanceUnit fromUnit)
        {
            return new ElectricAdmittance(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricAdmittanceUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricAdmittance ToUnit(ElectricAdmittanceUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricAdmittance(convertedValue, unit);
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
                case ElectricAdmittanceUnit.Microsiemens: return (_value) * 1e-6d;
                case ElectricAdmittanceUnit.Millisiemens: return (_value) * 1e-3d;
                case ElectricAdmittanceUnit.Nanosiemens: return (_value) * 1e-9d;
                case ElectricAdmittanceUnit.Siemens: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ElectricAdmittanceUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ElectricAdmittanceUnit.Microsiemens: return (baseUnitValue) / 1e-6d;
                case ElectricAdmittanceUnit.Millisiemens: return (baseUnitValue) / 1e-3d;
                case ElectricAdmittanceUnit.Nanosiemens: return (baseUnitValue) / 1e-9d;
                case ElectricAdmittanceUnit.Siemens: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

