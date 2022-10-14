#ifndef STRANGENUMBER_H
#define STRANGENUMBER_H

class StrangeNumber
{
public:
	StrangeNumber();
	virtual ~StrangeNumber();

	double getDouble() const;
	void setDouble(double value);

	void add(double value);
	void substract(double value);
	void divide(double value);
	void multiply(double value);

private:
	double _value;

};

#endif