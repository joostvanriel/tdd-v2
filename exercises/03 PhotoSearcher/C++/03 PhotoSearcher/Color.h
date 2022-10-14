#pragma once

class Color
{
public:
	Color(int red, int green, int blue);
	virtual ~Color();

	bool operator==(const Color& other) const;

private:
	int _red;
	int _green;
	int _blue;
};

