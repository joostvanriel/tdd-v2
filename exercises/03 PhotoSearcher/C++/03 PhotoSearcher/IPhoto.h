#pragma once

#include "date.h"
#include "Color.h"
#include "ContentType.h"

struct IPhoto
{
	virtual ~IPhoto() = 0;

	virtual int getId() const = 0;
	virtual const date::year_month_day& getDate() const = 0;
	virtual const Color& getColor() const = 0;
	virtual ContentType getContentType() const = 0;
};

inline IPhoto::~IPhoto()
{
}
