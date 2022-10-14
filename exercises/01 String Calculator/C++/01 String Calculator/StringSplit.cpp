#include "StringSplit.h"
#include <string>
#include <vector>
#include <regex>

std::vector<std::string> split(const std::string& str, const std::vector<std::string>& delimiters)
{
	std::vector<std::string> strings;
	std::string::size_type startPos = 0;
	std::string::size_type currentPos = 0;
	const std::string::size_type length = str.length();
	while (currentPos < length)
	{
		auto it = std::find_if(delimiters.begin(), delimiters.end(),
			[str, currentPos](std::string delimiter) { return str.substr(currentPos, delimiter.length()) == delimiter; });

		if (it != delimiters.end())
		{
			strings.push_back(str.substr(startPos, currentPos - startPos));
			startPos = currentPos + it->length();
			currentPos = startPos;
		}
		else
		{
			++currentPos;
		}
	}
	strings.push_back(str.substr(startPos));

	return strings;
}