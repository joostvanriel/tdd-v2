#pragma once

#include <memory>
#include "ContentType.h"

struct IPhotoRepository;
class FuzzyDate;
class Color;

class PhotoDeleter
{
public:
	PhotoDeleter(IPhotoRepository* photoRepository);
	virtual ~PhotoDeleter();

	void deletePhotos(const FuzzyDate& fuzzyDate);
	void deletePhotos(const FuzzyDate& fuzzyDate, const Color& color, ContentType contentType);

private:
	IPhotoRepository* _photoRepository;

};
