#include "gtest/gtest.h"
#include "gmock/gmock.h"
#include <vector>

using namespace testing;

class CruiseControlTest : public Test
{
public:
	void SetUp() override
	{

	}
};

TEST_F(CruiseControlTest, Example)
{
	ASSERT_TRUE(true);
}