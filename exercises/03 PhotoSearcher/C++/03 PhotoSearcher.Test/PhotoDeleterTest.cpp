#include "../03 PhotoSearcher/PhotoDeleter.h"
#include "../03 PhotoSearcher/FuzzyDate.h"
#include "../03 PhotoSearcher/IPhotoRepository.h"
#include "../03 PhotoSearcher/IPhoto.h"
#include "gtest/gtest.h"
#include <vector>

using namespace testing;
using namespace std;

class PhotoDeleterTest : public ::testing::Test
{
public:
	virtual void SetUp()
	{
	}
};

TEST_F(PhotoDeleterTest, Example)
{
	EXPECT_TRUE(true);
}