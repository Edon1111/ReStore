import {
  Avatar,
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Typography,
} from "@mui/material";
import { Link } from "react-router-dom";
import { Blog } from "../../app/models/blog";

interface Props {
  blog: Blog;
}
export default function BlogCard({ blog }: Props) {
  return (
    <Card>
      <CardHeader
        avatar={
          <Avatar sx={{ bgcolor: "secondary.main" }}>
            {blog.blogName.charAt(0).toUpperCase()}
          </Avatar>
        }
        title={blog.blogName}
        titleTypographyProps={{
          sx: { fontWeight: "bold", color: "primary.main" },
        }}
      />
      <CardMedia
        sx={{
          height: 140,
          //   backgroundSize: "contain",
          bgcolor: "primary.light",
        }}
        image={blog.pictureUrl}
        title={blog.blogName}
      />
      <CardContent>
        {/* <Typography variant="body2" color="text.secondary">
          {blog.brand} / {blog.type}
        </Typography> */}
      </CardContent>
      <CardActions>
        <Typography gutterBottom color="gray" variant="subtitle2">
          {blog.dataArtikullit}
        </Typography>
        <Button component={Link} to={`/blog/${blog.id}`} size="small">
          View
        </Button>
      </CardActions>
    </Card>
  );
}
