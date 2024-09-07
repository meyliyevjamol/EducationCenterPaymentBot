using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace EducationCenterPaymentBot.BizLogiclayer.Services;

public partial class BotUpdateHandler
{
    private async Task HandleMessageAsync(ITelegramBotClient botClient, Message? message, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(nameof(message));

        //var from = message.From;
        //var handler = message.Type switch
        //{
        //    MessageType.Text => HandleMessageAsync(botClient, message, cancellationToken),
        //    //UpdateType.EditedMessage => HandleEditedMessageAsync(botClient, update.EditedMessage, cancellationToken),
        //    _ => HandleUnknownUpdateAsync(botClient, update, cancellationToken),

        //};

        //try
        //{
        //    await handler;
        //}
        //catch (Exception ex)
        //{
        //    await HandlePollingErrorAsync(botClient, ex, cancellationToken);
        //}
    }
}
