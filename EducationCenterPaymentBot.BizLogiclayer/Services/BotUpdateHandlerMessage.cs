using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Microsoft.Extensions.Logging;

namespace EducationCenterPaymentBot.BizLogiclayer;

public partial class BotUpdateHandler
{
    private async Task HandleMessageAsync(ITelegramBotClient botClient, Message? message, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(nameof(message));

        var from = message.From;

        _logger.LogInformation($"Received message from {from?.FirstName}");
    }
}