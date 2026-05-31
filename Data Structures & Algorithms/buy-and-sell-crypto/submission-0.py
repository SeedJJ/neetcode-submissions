class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        lowestBuy = prices[0]
        highestSell = prices[0]
        maxProfit = 0
        currentProfit = 0
        for price in prices:
            if price > highestSell:
                highestSell = price
                currentProfit = highestSell - lowestBuy
            if price < lowestBuy:
                lowestBuy = price
                highestSell = price
                currentProfit = highestSell - lowestBuy
            maxProfit = max(maxProfit, currentProfit)
        return maxProfit
