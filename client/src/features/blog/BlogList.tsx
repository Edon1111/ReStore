import { Grid, List } from "@mui/material";
import { Blog } from "../../app/models/blog";
import BlogCard from "./BlogCard";

interface Props {
  blogs: Blog[];
}
export default function BlogList({ blogs }: Props) {
  return (
    <Grid container spacing={4}>
      {blogs.map((blog) => (
        <Grid item xs={4} key={blog.id}>
          <BlogCard blog={blog} />
        </Grid>
      ))}
    </Grid>
  );
}
