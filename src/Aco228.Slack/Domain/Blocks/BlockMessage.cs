using Aco228.Slack.Domain.Blocks.Core;

namespace Aco228.Slack.Domain.Blocks;

public class BlockMessage
{
    public List<BlockBase> Blocks { get; set; } = new();

    public void Add(BlockBase block)
        => Blocks.Add(block);
}