#include "Color.h"

Color::Color(int red, int green, int blue) :
	_red(red),
	_green(green),
	_blue(blue)
{
}

Color::~Color()
{
}

bool Color::operator==(const Color& other) const
{
	return
		_red == other._red &&
		_green == other._green &&
		_blue == other._blue;
}
