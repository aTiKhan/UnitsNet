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
    ///     Molar entropy is amount of energy required to increase temperature of 1 mole substance by 1 Kelvin.
    /// </summary>
    public struct  MolarEntropy
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarEntropyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MolarEntropyUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MolarEntropy(double value, MolarEntropyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MolarEntropyUnit ConversionBaseUnit { get; } = MolarEntropyUnit.JoulePerMoleKelvin;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static MolarEntropy MaxValue { get; } = new MolarEntropy(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static MolarEntropy MinValue { get; } = new MolarEntropy(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MolarEntropy Zero { get; } = new MolarEntropy(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get MolarEntropy in JoulesPerMoleKelvin.
        /// </summary>
        public double JoulesPerMoleKelvin => As(MolarEntropyUnit.JoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy in KilojoulesPerMoleKelvin.
        /// </summary>
        public double KilojoulesPerMoleKelvin => As(MolarEntropyUnit.KilojoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy in MegajoulesPerMoleKelvin.
        /// </summary>
        public double MegajoulesPerMoleKelvin => As(MolarEntropyUnit.MegajoulePerMoleKelvin);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get MolarEntropy from JoulesPerMoleKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEntropy FromJoulesPerMoleKelvin(double joulespermolekelvin) => new MolarEntropy(joulespermolekelvin, MolarEntropyUnit.JoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy from KilojoulesPerMoleKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEntropy FromKilojoulesPerMoleKelvin(double kilojoulespermolekelvin) => new MolarEntropy(kilojoulespermolekelvin, MolarEntropyUnit.KilojoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy from MegajoulesPerMoleKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEntropy FromMegajoulesPerMoleKelvin(double megajoulespermolekelvin) => new MolarEntropy(megajoulespermolekelvin, MolarEntropyUnit.MegajoulePerMoleKelvin);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEntropyUnit" /> to <see cref="MolarEntropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEntropy unit value.</returns>
        public static MolarEntropy From(double value, MolarEntropyUnit fromUnit)
        {
            return new MolarEntropy(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MolarEntropyUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public MolarEntropy ToUnit(MolarEntropyUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new MolarEntropy(convertedValue, unit);
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
                case MolarEntropyUnit.JoulePerMoleKelvin: return _value;
                case MolarEntropyUnit.KilojoulePerMoleKelvin: return (_value) * 1e3d;
                case MolarEntropyUnit.MegajoulePerMoleKelvin: return (_value) * 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(MolarEntropyUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case MolarEntropyUnit.JoulePerMoleKelvin: return baseUnitValue;
                case MolarEntropyUnit.KilojoulePerMoleKelvin: return (baseUnitValue) / 1e3d;
                case MolarEntropyUnit.MegajoulePerMoleKelvin: return (baseUnitValue) / 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

