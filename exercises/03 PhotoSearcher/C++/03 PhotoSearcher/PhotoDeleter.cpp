#include "PhotoDeleter.h"
#include <vector>
#include <algorithm>
#include <iterator>
#include "FuzzyDate.h"
#include "Color.h"
#include "IPhotoRepository.h"
#include "IPhoto.h"

using namespace std;

PhotoDeleter::PhotoDeleter(IPhotoRepository* photoRepository) :
	_photoRepository(photoRepository)
{
}

PhotoDeleter::~PhotoDeleter()
{
}

void PhotoDeleter::deletePhotos(const FuzzyDate& fuzzyDate)
{
}

void PhotoDeleter::deletePhotos(const FuzzyDate & fuzzyDate, const Color & color, ContentType contentType)
{
}
