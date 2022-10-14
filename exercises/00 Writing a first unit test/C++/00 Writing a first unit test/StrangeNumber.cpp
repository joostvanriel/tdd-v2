#include "StrangeNumber.h"

StrangeNumber::StrangeNumber() :
	_value(0.0)
{
}

StrangeNumber::~StrangeNumber()
{
}

double StrangeNumber::getDouble() const
{
	return _value;
}

void StrangeNumber::setDouble(double value)
{
	_value = value;
}

void StrangeNumber::add(double value)
{
	_value += value;
}

void StrangeNumber::substract(double value)
{
	_value -= value;
}

void StrangeNumber::divide(double value)
{
	_value /= value;
}

void StrangeNumber::multiply(double value)
{
	_value *= value;
}
