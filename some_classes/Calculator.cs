using System;

public class Calculator
{
    private decimal _decimalValue;
    private int _binaryValue;
    private bool _isDecimalMode;

    public Calculator()
    {
        _decimalValue = 0;
        _binaryValue = 0;
        _isDecimalMode = true;
    }

    public decimal DecimalValue
    {
        get { return _isDecimalMode ? _decimalValue : (decimal)_binaryValue; }
        private set
        {
            if (_isDecimalMode)
            {
                _decimalValue = value;
            }
            else
            {
                _binaryValue = (int)value;
            }
        }
    }

    public bool IsDecimalMode
    {
        get { return _isDecimalMode; }
        private set { _isDecimalMode = value; }
    }

    public void Add(decimal value)
    {
        DecimalValue += value;
    }

    public void Subtract(decimal value)
    {
        DecimalValue -= value;
    }

    public void Multiply(decimal value)
    {
        DecimalValue *= value;
    }

    public void Divide(decimal value)
    {
        if (value != 0)
        {
            DecimalValue /= value;
        }
    }

    public void SetDecimalMode()
    {
        if (!_isDecimalMode)
        {
            _isDecimalMode = true;
            _decimalValue = (decimal)_binaryValue;
        }
    }

    public void SetBinaryMode()
    {
        if (_isDecimalMode)
        {
            _isDecimalMode = false;
            _binaryValue = (int)_decimalValue;
        }
    }
}
