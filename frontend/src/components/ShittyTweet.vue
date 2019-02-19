<template>
  <div class="container">
    <div class="row justify-content-center">
      <div class="shitty-tweet col-md-8">
        <p>{{ shittyTweet.message }}</p>
        <small>{{ shittyTweet.author }} | {{ shittyTweet.published }}</small>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "ShittyTweet",
  props: {
    shittyTweet: {
      type: Object,
      required: true,
    }
  },
  data() {
    return {
      tweet: {
        message: "Test message",
        author: "meee",
        published: "11/22/22"
      }
    }
  }
}
</script>

<style>
.shitty-tweet {
  padding: 25px;
  margin-bottom: 20px;
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
  transition: 0.3s;
  background-color: #fff;
  border-radius: 5px;
}
.shitty-tweet:hover {
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
}
</style>
