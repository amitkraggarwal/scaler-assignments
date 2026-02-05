public static class BotPlayingStrategyFactory
{
    public static BotPlayingStrategy GetStrategy(BotDifficultyLevel difficultyLevel)
    {
        switch (difficultyLevel)
        {
            case BotDifficultyLevel.EASY:
                return new EasyLevelStrategy();
            case BotDifficultyLevel.MEDIUM:
                return new MediumLevelStrategy();
            case BotDifficultyLevel.HARD:
                return new DifficultLevelStrategy();
            default:
                throw new ArgumentException("Invalid Bot Difficulty Level");
        }
    }
}