package stringcalculator

import (
	"strconv"
	"strings"
)

func Add(numbers string) int {
	if numbers == "" {
		return 0
	} else {
		var delimiter string = ","
		var numbersToProcess string = numbers

		// Check for custom delimiter
		if strings.HasPrefix(numbers, "//") {
			// Extract custom delimiter and numbers
			delimiterEndIndex := strings.Index(numbers[2:], "\n")
			if delimiterEndIndex != -1 {
				delimiter = string(numbers[2])
				numbersToProcess = numbers[2+delimiterEndIndex+1:]
			}
		}

		// Replace newlines with the delimiter, then split on delimiter
		normalized := strings.ReplaceAll(numbersToProcess, "\n", delimiter)
		parts := strings.Split(normalized, delimiter)
		sum := 0
		for _, p := range parts {
			num, err := strconv.Atoi(p)
			if err != nil {
				panic("Invalid input: " + p)
			}
			sum += num
		}
		return sum
	}
}
