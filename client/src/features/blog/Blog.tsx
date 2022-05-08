import { useState, useEffect } from "react";
import agent from "../../app/api/agent";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { Blog } from "../../app/models/blog";
import BlogList from "./BlogList";

export default function Catalog() {
  const [blogs, setBlogs] = useState<Blog[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    agent.Blog.list()
      .then((blogs) => setBlogs(blogs))
      .catch((error) => console.log(error))
      .finally(() => setLoading(false));
  }, []);

  if (loading) return <LoadingComponent message="Loading blogs..." />;

  return (
    <>
      <BlogList blogs={blogs} />
    </>
  );
}
