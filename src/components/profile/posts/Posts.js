import React from 'react'
import Post from './post/Post.js'



function Posts(props){
    return(
    <div className='posts'>
        <h2>My posts</h2>
        <input placeholder='enter the post' />
        <button>Add post</button>
        {props.postsItems.map((e)=> <Post message={e.message} likes={e.likes}/> )}
    </div>
    )
}
export default Posts