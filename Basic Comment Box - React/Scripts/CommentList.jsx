class CommentList extends React.Component {
    render() {
        const commentNodes = this.props.data.map(comment => {
            <Comment author={comment.Author} key={commentId}>
                {comment.Text}
            </Comment>
        });
        return (
            <div className="commentList">
                {commentNodes}
            </div>
        );
    }
}