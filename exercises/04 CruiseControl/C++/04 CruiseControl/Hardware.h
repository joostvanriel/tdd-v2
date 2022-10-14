#pragma once

class Hardware
{
public:
	static Hardware& getInstance();

	void accelerate(bool accelerate);
	int getCurrentSpeed() const;

	bool isBreakPressed() const;
	bool isClutchPressed() const;

	bool isCruiseControlOn() const;
	void disableCruiseControl();
	int getCruiseControlSpeed() const;

private:
	Hardware();
	~Hardware();

	static Hardware* _instance;

};
