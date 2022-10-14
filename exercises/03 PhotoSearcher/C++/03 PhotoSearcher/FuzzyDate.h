#pragma once

#include <string>
#include <chrono>
#include "date.h"

enum class Quarters
{
	Q1,
	Q2,
	Q3,
	Q4
};

enum class YearType
{
	START,
	HALFWAY,
	END
};

class FuzzyDate
{
public:
	FuzzyDate();
	FuzzyDate(const std::string& str);
	FuzzyDate(Quarters quart, int year);
	FuzzyDate(YearType type, int year);
	virtual ~FuzzyDate();

	const date::year_month_day& getFuzzyStart() const;
	const date::year_month_day& getFuzzyEnd() const;
	date::days getFuzzyRange() const;
	bool contains(const date::year_month_day& lookupDate) const;

private:
	date::year_month_day _startDate;
	date::year_month_day _endDate;

};
