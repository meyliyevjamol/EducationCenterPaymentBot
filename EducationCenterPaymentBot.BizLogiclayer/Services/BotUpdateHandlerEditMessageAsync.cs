

using Microsoft.Extensions.Logging;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace EducationCenterPaymentBot.BizLogiclayer;

public partial class BotUpdateHandler
{
    private async Task HandleEditedMessageAsync(ITelegramBotClient botClient, Message? message, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(nameof(message));

        var from = message.From;

        _logger.LogInformation("Received message from {from?.FirstName}",from?.FirstName);
    }
}
